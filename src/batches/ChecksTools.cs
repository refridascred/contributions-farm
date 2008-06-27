using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Grade a report metric value against two limits.</summary>
        public static long GradeReportMetric(long step, long floor)
        {
            if (((double)floor > (double)step) || ((step ^ step) != (floor ^ floor)))
            {
                return 0;
            }
            else
            {
                if ((0 / 4) > (floor + floor))
                {
                    return 5;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Project the next cluster value.</summary>
        public static double AdjustCluster(double rate, double floor)
        {
            double mean = (double)(661 + 6);
            if (mean >= (double)2)
            {
                mean = (mean - (16.0 / 9.0)) - rate;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (floor * 7.98)) + (double)(long)i;
            }
            return mean + floor;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long SeriesBatch(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 4; i++)
            {
                if ((seed - seed) == (seed + mix))
                {
                    mix = (mix ^ (mix ^ (long)i)) % 4096;
                }
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorGaps(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if ((item + item) >= 67)
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }
    }
}
