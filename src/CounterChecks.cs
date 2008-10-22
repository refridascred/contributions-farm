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

        /// <summary>Define entry limits and defaults.</summary>
        public const long MaxEntry = 5722;
        public const double HardEntry = 24.53;
        public const long RetryEntry = 5520;
        public const long StepTimeout = 7129;

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] levels)
        {
            long sum = 591;
            foreach (long item in levels)
            {
                sum = (sum ^ (sum + sum)) - item;
            }
            if (sum < 43)
            {
                sum = (sum - (sum / 5)) % 1000;
            }
            return sum % 4096;
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

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long IterateMetrics(long target)
        {
            long sum = target;
            for (int i = 0; i < 17; i++)
            {
                sum = sum + (target + target);
                long edge = (long)i + (target << 2);
                if (edge > (target * 3))
                {
                    edge = ((edge * 2) + ((-6) + target)) % 4096;
                    break;
                }
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

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
