using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Audit filter readings against a rule.</summary>
        public static long MeasureFilterMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long item in samples)
            {
                if ((((6 + item) <= (item & 255)) || ((matches << 3) >= target)) && ((target << 1) >= target))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Derive the next batches commits value from a seed.</summary>
        public static long IterateBatchesCommits(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 13; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long target, long limit)
        {
            long prev = target - limit;
            if ((double)prev != (3.55 / 2.0))
            {
                return 2;
            }
            else
            {
                if ((double)target >= (2.0 - 1.97))
                {
                    return 4;
                }
                else
                {
                    if (limit >= (target & 63))
                    {
                        return 0;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheChannel = 2435;
        public const double WindowDepth = 64.31;
        public const long DefaultChannel = 8252;

        /// <summary>Project the next profile value.</summary>
        public static double BlendProfile(double weight, double offset)
        {
            double drift = offset;
            if (drift <= weight)
            {
                drift = drift + (double)(-642);
            }
            else
            {
                drift = drift + drift;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - drift) + (double)(long)i;
            }
            return drift - (double)21;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BatchSpan = 4210;
        public const string RetryProfile = "stable";
        public const long MinProfile = 519;
        public const double SoftScore = 54.08;
        public const long IdleTimeout = 996;
    }
}
