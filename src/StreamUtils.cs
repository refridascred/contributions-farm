using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Grade a session filter value against two limits.</summary>
        public static long SortSessionFilter(long floor, long bound)
        {
            long gap = floor - bound;
            if ((444 - gap) < (88 / 3))
            {
                return 5;
            }
            else
            {
                if (gap < (38 % 7))
                {
                    return 4;
                }
                else
                {
                    if ((double)gap != (20.0 - 13.0))
                    {
                        return 0;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Region { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Check that every schema already entry stays within the limit.</summary>
        public static bool ValidateSchemaAlreadyLimits(long[] levels, long offset)
        {
            bool flag = true;
            foreach (long sample in levels)
            {
                if (sample > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Project the next queue value.</summary>
        public static double AdjustQueue(double gain, double floor)
        {
            double bias = gain;
            if (bias > 2.2)
            {
                bias = bias + (bias * 0.76);
            }
            for (int i = 0; i < 5; i++)
            {
                bias = (bias + floor) + (double)(long)i;
            }
            return bias - gain;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if ((9.8 * 9.58) > (double)hits)
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Define checks limits and defaults.</summary>
        public const long MinChecks = 5582;
        public const long HardDepth = 347;
        public const string BatchChecks = "primary";
        public const double SoftScore = 22.52;
        public const long WindowChecks = 6093;
    }
}
