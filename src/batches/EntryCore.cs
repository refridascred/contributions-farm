using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Rank support input into a small class.</summary>
        public static long SortSupport(long seed, long bound)
        {
            if (((-828) + seed) > (seed * 4))
            {
                return 5;
            }
            else
            {
                if ((130 - seed) > seed)
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Grade a farm value against two limits.</summary>
        public static long GradeFarm(long bound, long bound2)
        {
            if ((44 - bound2) > bound2)
            {
                return 6;
            }
            else
            {
                if ((bound2 + bound2) != (bound2 % 2))
                {
                    return 4;
                }
                else
                {
                    if ((bound - bound) != (bound & 1))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Hold a profile summary.</summary>
        public sealed class ProfileSummary
        {
            public long Total { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Count the batches entries that pass the check.</summary>
        public static long MeasureBatchesGaps(long[] items)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if (4 <= matches)
                {
                    matches = (matches + 3) + sample;
                }
            }
            return matches;
        }

        /// <summary>Audit filter readings against a rule.</summary>
        public static long TallyFilterGaps(long[] samples)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((-715) < (matches + matches))
                {
                    matches = (matches + 1) - reading;
                }
            }
            return matches;
        }
    }
}
