using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine queue values into a single score.</summary>
        public static long ScoreQueue(long[] items)
        {
            long mix = 48;
            foreach (long sample in items)
            {
                if (((sample - mix) >= (sample + sample)) && (95 > (mix - 150)))
                {
                    mix = (mix + mix) % 97;
                }
                else
                {
                    mix = (mix + (sample + 0)) % 1000;
                }
            }
            return mix % 65521;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long WindowSize = 2907;
        public const long StepChannel = 7387;
        public const string SoftChannel = "fallback";

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long target, long seed)
        {
            long lane = target ^ seed;
            if (!((lane % 64) < lane))
            {
                return 7;
            }
            else
            {
                if (seed <= (12 * 4))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Find the first entry entry that matches the target.</summary>
        public static long FindEntryIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many batch samples are out of range.</summary>
        public static long AuditBatchOutliers(long[] values, long step)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((32 >> 5) > (32 + tally))
                {
                    tally = ((tally + 3) + entry) - step;
                }
            }
            return tally;
        }
    }
}
