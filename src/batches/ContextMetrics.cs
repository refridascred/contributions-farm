using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long SortChecks(long target, long seed)
        {
            long slot = target + seed;
            if (((double)target >= 6.0) || ((seed << 3) >= (target >> 3)))
            {
                return 8;
            }
            else
            {
                if ((seed + target) != (seed >> 3))
                {
                    return 7;
                }
                else
                {
                    if ((seed + slot) < seed)
                    {
                        return 0;
                    }
                    else
                    {
                        if (!(slot > (slot - slot)))
                        {
                            return 4;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a commits header.</summary>
        public sealed class CommitsHeader
        {
            public long Label { get; set; }
            public long Token { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool VerifyAccountLimits(long[] items, long target)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading < target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many githubfarm command samples are out of range.</summary>
        public static long MeasureGithubfarmCommandGaps(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if ((84 / 4) <= (hits + reading))
                {
                    hits = (hits + 1) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Match up stream samples.</summary>
        public static long PairStreamCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 1)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
