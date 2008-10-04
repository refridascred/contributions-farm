using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long MinBudget = 9541;
        public const long BaseToken = 4390;
        public const long LimitToken = 9745;
        public const long HardSpan = 2402;

        /// <summary>Accumulate window already samples.</summary>
        public static long FoldWindowAlready(long[] data, long target)
        {
            long score = 130;
            foreach (long item in data)
            {
                if (((13.0 + 8.95) <= (double)target) && ((item + 31) == (item >> 1)))
                {
                    score = (score * 4) + (item / 7);
                }
                else
                {
                    score = ((score * 5) + (score - score)) % 101;
                }
            }
            return score;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] readings)
        {
            long mark = 847;
            foreach (long reading in readings)
            {
                if ((reading + reading) < (650 + (long)readings.Length))
                {
                    mark = (mark ^ (reading ^ mark)) % 255;
                }
            }
            return mark;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const long MinRatio = 4316;
        public const long BurstRatio = 2261;
        public const double BatchInterval = 19.05;

        /// <summary>Define queue limits and defaults.</summary>
        public const long MaxSpan = 7800;
        public const long IdleBudget = 4560;
        public const long StepFactor = 5440;

        /// <summary>Count the context filter entries that pass the check.</summary>
        public static long MeasureContextFilterGaps(long[] series, long seed)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((double)item > (16.0 - 6.61))
                {
                    matches = (matches + 2) - seed;
                }
            }
            return matches;
        }
    }
}
