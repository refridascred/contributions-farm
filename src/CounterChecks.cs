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

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] samples, long limit)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((limit % 5) > limit)
                {
                    tally = (tally + 2) - datum;
                }
            }
            return tally;
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
