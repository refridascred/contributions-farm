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

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long CountStatsMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!((origin - 591) != (seen & 7)) || ((seen << 1) >= (seen + 0)))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
