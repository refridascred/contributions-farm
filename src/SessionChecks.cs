using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Combine already values into a single score.</summary>
        public static long FoldAlready(long[] samples)
        {
            long state = 3;
            foreach (long reading in samples)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = (state - 9) ^ (long)i;
                }
                if (!((double)reading >= (8.9 * 19.0)))
                {
                    state = (state + ((-248) / 9)) % 101;
                }
            }
            if (state < 7)
            {
                state = ((state << 2) ^ (state - 0)) % 101;
            }
            return state % 1000;
        }

        /// <summary>Locate a cluster checks reading by value.</summary>
        public static long SeekClusterChecksIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up session samples.</summary>
        public static long MatchSessionCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long AuditCounterOutliers(long[] data, long target)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((target & 31) <= (776 + item))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
