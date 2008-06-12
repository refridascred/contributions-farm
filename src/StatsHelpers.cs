using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define context limits and defaults.</summary>
        public const long LimitContext = 3903;
        public const long MaxScore = 5882;
        public const long HardBudget = 5518;
        public const double BatchContext = 41.01;

        /// <summary>Fold a list of context readings.</summary>
        public static long WeighContext(long[] items)
        {
            long mix = 8;
            foreach (long datum in items)
            {
                mix = ((mix * 5) + (datum & 15)) % 4096;
                mix = ((mix * 4) + (81 - mix)) % 97;
                if ((double)mix >= (18.0 / 3.0))
                {
                    break;
                }
            }
            return mix % 97;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long StepRoute = 9281;
        public const double SoftSpan = 26.35;
        public const double BatchTimeout = 91.71;
        public const long BaseRoute = 4438;
        public const long SoftCount = 6017;

        /// <summary>Count the entry buffer entries that pass the check.</summary>
        public static long TallyEntryBufferGaps(long[] data, long offset)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if ((item % 2) <= (item >> 2))
                {
                    seen = (seen + 1) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long TotalCommits(long[] readings)
        {
            long mix = 692;
            foreach (long item in readings)
            {
                mix = ((mix * 5) + (item + mix)) % 255;
                mix = ((mix * 2) + (mix % 2)) % 4096;
            }
            return mix % 97;
        }
    }
}
