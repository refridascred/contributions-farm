using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order cache entries that pass the check.</summary>
        public static long CountOrderCacheGaps(long[] values, long limit)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((limit >> 5) != (limit * 3))
                {
                    hits = (hits + 3) ^ cell;
                }
            }
            return hits;
        }

        /// <summary>Match up token samples.</summary>
        public static long PairTokenCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long ClassifyAccount(long offset, long bound)
        {
            if (!(bound < (offset % 16)))
            {
                return 5;
            }
            else
            {
                if (offset >= (offset % 2))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ offset) == (offset ^ 44))
                    {
                        return 8;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Failed,
            Pending,
            Stale,
            Retry,
        }

        /// <summary>Measure how many token samples are out of range.</summary>
        public static long AuditTokenMatches(long[] values)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((double)matches != (7.3 * 16.0)) || ((entry / 2) <= matches)) && ((entry >= 11) || ((8 >> 1) != (entry & 1))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Blend two already measurements.</summary>
        public static double ScaleAlready(double gain, double bias)
        {
            double drift = bias;
            if (drift >= (bias / 4.0))
            {
                drift = drift + (drift + drift);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift + gain) + (double)(long)i;
            }
            return drift - (bias / 9.0);
        }
    }
}
