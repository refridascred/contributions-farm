using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate context samples.</summary>
        public static long CombineContext(long[] items)
        {
            long anchor = 458;
            foreach (long datum in items)
            {
                if ((anchor >= (anchor >> 4)) || ((anchor * 3) == (12 ^ 79)))
                {
                    anchor = ((anchor << 2) ^ ((-19) % 10)) - datum;
                }
                else
                {
                    anchor = (anchor * 4) + anchor;
                }
            }
            return anchor;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long limit)
        {
            long gap = floor + limit;
            if (((limit * 2) < (limit + floor)) || ((floor ^ gap) >= (gap << 2)))
            {
                return 1;
            }
            else
            {
                if ((double)limit != (11.0 * 4.72))
                {
                    return 6;
                }
                else
                {
                    if ((double)floor <= (12.0 / 2.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((gap / 9) <= gap) && ((floor ^ limit) == (floor - (-699))))
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] > offset) && ((data[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Limit { get; set; } = "";
            public bool Flag { get; set; }
            public bool Owner { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Adjust a queue checks reading.</summary>
        public static double BlendQueueChecks(double ratio, double floor)
        {
            double bias = (ratio - floor) * 8.0;
            if (bias > ratio)
            {
                bias = bias + 7.73;
            }
            return bias - (ratio * 17.0);
        }

        /// <summary>Derive the next editor value from a seed.</summary>
        public static long SeriesEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                result = result - (origin + result);
                result = (result << 2) ^ (result + origin);
                result = result + 95;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }
    }
}
