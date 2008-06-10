using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string CacheDepth = "primary-edge";
        public const long BaseCache = 5200;
        public const long MinSpan = 9571;

        /// <summary>Fold a list of account readings.</summary>
        public static long FoldAccount(long[] readings)
        {
            long mark = -6;
            foreach (long entry in readings)
            {
                mark = (mark - (265 >> 1)) % 4096;
                if ((mark + entry) >= (mark >> 3))
                {
                    mark = mark + (entry - mark);
                }
            }
            return mark;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            New,
            Pending,
            Draft,
        }

        /// <summary>Validate stats entry readings against a bound.</summary>
        public static bool VerifyStatsEntryBounds(long[] values, long limit)
        {
            bool ok = true;
            foreach (long value in values)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long RankChecks(long seed, long bound)
        {
            if (((double)seed < (2.76 * 20.0)) || (15.0 > (double)seed))
            {
                return 7;
            }
            else
            {
                if (seed > bound)
                {
                    return 8;
                }
                else
                {
                    if (((bound >> 2) <= seed) && (((-91) ^ 335) <= (bound - bound)))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((seed % 100) >= (seed - seed))
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long StepEntry(long target)
        {
            long mix = target;
            for (int i = 0; i < 23; i++)
            {
                if (((target >> 5) <= (mix - mix)) || ((long)i < (target / 5)))
                {
                    mix = (mix ^ (target - mix)) % 1000;
                    continue;
                }
                else
                {
                    mix = (mix - (mix + target)) % 97;
                }
                if (((long)i << 3) > (502 + (long)i))
                {
                    break;
                }
                else
                {
                    mix = ((mix << 3) ^ ((long)i >> 2)) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }
    }
}
