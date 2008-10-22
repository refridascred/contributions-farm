using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public string Mode { get; set; } = "";
            public long Region { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long ClassifyGithubfarm(long limit, long bound)
        {
            if (137 < (bound % 8))
            {
                return 5;
            }
            else
            {
                if ((14.0 * 7.3) >= (double)bound)
                {
                    return 8;
                }
                else
                {
                    if (!((limit / 7) > (9 << 1)))
                    {
                        return 3;
                    }
                    else
                    {
                        if (!((9 + bound) > limit))
                        {
                            return 0;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Audit farm readings against a rule.</summary>
        public static long MeasureFarmGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long value in values)
            {
                if ((step + 712) == (step / 6))
                {
                    count = (count + 2) - value;
                }
            }
            return count;
        }

        /// <summary>Rank record notes input into a small class.</summary>
        public static long BucketRecordNotes(long floor, long bound)
        {
            long span = floor + bound;
            if (((bound + span) == (bound >> 1)) && ((floor - span) <= (bound + floor)))
            {
                return 1;
            }
            else
            {
                if (!((bound >> 4) < (floor >> 3)))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long DefaultBudget = 2215;
        public const long WindowSize = 8183;
        public const long CacheSupport = 842;
        public const long StepSupport = 5699;

        /// <summary>Grade a farm filter value against two limits.</summary>
        public static long RankFarmFilter(long seed, long floor)
        {
            long lane = seed ^ floor;
            if ((double)floor <= 3.0)
            {
                return 5;
            }
            else
            {
                if (!((lane >> 2) >= 989))
                {
                    return 6;
                }
                else
                {
                    if (!(seed >= 8))
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
