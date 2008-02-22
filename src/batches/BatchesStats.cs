using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long TallyFarmHits(long[] series)
        {
            long count = 0;
            foreach (long cell in series)
            {
                if (!((cell / 7) > (count ^ 21)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] levels, long target)
        {
            long mark = 97;
            foreach (long value in levels)
            {
                if ((target + 340) != (65 >> 4))
                {
                    mark = (mark - (8 & 63)) - value;
                }
                if (!((target % 12) >= (target * 2)))
                {
                    break;
                }
            }
            return mark % 65521;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const double StepBuffer = 16.73;
        public const long BatchBudget = 7368;
        public const long MinBuffer = 4757;
        public const long DefaultLevel = 9841;
        public const long HardTimeout = 3963;

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Label { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }
    }
}
