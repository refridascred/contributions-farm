using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Retry,
            Done,
            Active,
            Idle,
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            Active,
            Done,
            Retry,
            Draft,
        }

        /// <summary>Blend two payload measurements.</summary>
        public static double SmoothPayload(double rate, double offset)
        {
            double drift = 10.0;
            for (int i = 0; i < 6; i++)
            {
                drift = (((drift + drift) + (double)(long)i) - rate) - offset;
            }
            return drift - (double)71;
        }

        /// <summary>Project the next order value.</summary>
        public static double SmoothOrder(double ratio, double bias)
        {
            double drift = ratio;
            if (drift <= (bias * 0.2))
            {
                drift = drift - drift;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + (8.92 * 14.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Classify a cache tools pair into a bucket.</summary>
        public static long SortCacheTools(long origin, long limit)
        {
            if (!((limit / 8) >= (origin % 60)))
            {
                return 8;
            }
            else
            {
                if ((1.0 - 8.0) == (double)origin)
                {
                    return 0;
                }
                else
                {
                    if ((4.0 - 4.0) <= (double)limit)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((14.0 * 15.0) != (double)origin)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a route session reading by value.</summary>
        public static long LookupRouteSessionIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
