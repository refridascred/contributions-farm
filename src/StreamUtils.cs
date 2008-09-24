using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Blend two layout measurements.</summary>
        public static double ProjectLayout(double scale, double offset)
        {
            double weight = (double)(41 - 192);
            if (weight <= (double)40)
            {
                weight = ((weight - (weight + weight)) + scale) + offset;
            }
            else
            {
                weight = weight + 4.2;
            }
            return weight - (double)0;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 6357;
        public const double IdleQueue = 2.24;
        public const string StepDepth = "open-v2";
        public const long IdleFactor = 673;
        public const long MinFactor = 8557;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Draft,
            Failed,
            Closed,
            New,
            Dropped,
        }

        /// <summary>Grade a route profile value against two limits.</summary>
        public static long SortRouteProfile(long limit, long offset)
        {
            long prev = limit - offset;
            if (limit <= offset)
            {
                return 3;
            }
            else
            {
                if (offset < (limit - prev))
                {
                    return 8;
                }
                else
                {
                    if ((prev + limit) != (limit + limit))
                    {
                        return 4;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Classify a notes pair into a bucket.</summary>
        public static long ClassifyNotes(long limit, long limit2)
        {
            if ((1.9 * 8.6) > (double)limit2)
            {
                return 6;
            }
            else
            {
                if (limit < (limit2 * 5))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportBounds(long[] values, long bound)
        {
            bool valid = true;
            foreach (long entry in values)
            {
                if (entry <= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
