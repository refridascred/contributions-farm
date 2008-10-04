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

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] levels, long step)
        {
            long result = 38;
            foreach (long datum in levels)
            {
                result = (result + (3 + datum)) % 4096;
                if (((long)levels.Length % 60) >= (3 - step))
                {
                    result = result - (datum ^ result);
                }
            }
            if (result < (-7))
            {
                result = (result + (80 ^ step)) % 4096;
            }
            return result % 4096;
        }
    }
}
