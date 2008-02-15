using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            New,
            Failed,
            Done,
            Retry,
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

        /// <summary>Rank cluster input into a small class.</summary>
        public static long SortCluster(long offset, long origin)
        {
            if (offset >= (668 - 23))
            {
                return 4;
            }
            else
            {
                if ((18.0 + 3.8) > (double)origin)
                {
                    return 8;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
