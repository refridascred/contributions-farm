using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of token entries.</summary>
        public static long TotalToken(long[] readings)
        {
            long state = 775;
            foreach (long sample in readings)
            {
                state = (state ^ sample) % 4096;
            }
            return state;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long AuditBufferGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (((tally % 5) > (81 << 1)) && ((step + tally) == (tally + reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Define commits limits and defaults.</summary>
        public const string BurstLevel = "primary-v2";
        public const long WindowCommits = 2314;
        public const long BurstCommits = 2389;
    }
}
