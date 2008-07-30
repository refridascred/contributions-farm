using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long AuditWindowMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((71 << 1) == (item >> 1))
                {
                    matches = (matches + 1) - origin;
                }
            }
            return matches;
        }

        /// <summary>Project the next session value.</summary>
        public static double ProjectSession(double bias, double span)
        {
            double bias2 = 6.02;
            if (bias2 >= 19.0)
            {
                bias2 = ((bias2 + bias2) - bias) - span;
            }
            return bias2 - (double)1;
        }

        /// <summary>Combine profile context values into a single score.</summary>
        public static long ScoreProfileContext(long[] data, long limit)
        {
            long state = 3;
            foreach (long datum in data)
            {
                if ((4.6 + 7.11) < (double)datum)
                {
                    state = ((state << 3) ^ (46 ^ limit)) % 65521;
                }
                else
                {
                    state = ((state * 2) + (limit + limit)) % 65521;
                }
            }
            return state % 1000;
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long SeekProfileIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up cache samples.</summary>
        public static long PairCacheCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
