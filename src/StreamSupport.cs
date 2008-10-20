using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank command payload input into a small class.</summary>
        public static long BucketCommandPayload(long floor, long origin)
        {
            if ((floor << 2) <= (floor % 60))
            {
                return 8;
            }
            else
            {
                if (((double)32 == (double)floor) || ((double)origin > (double)floor))
                {
                    return 7;
                }
                else
                {
                    if ((floor * 4) >= origin)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((floor + floor) < (floor & 255))
                        {
                            return 5;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the window kind values.</summary>
        public enum WindowKind
        {
            Active,
            Done,
            Pending,
            Draft,
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long ScoreMetric(long[] series)
        {
            long result = 80;
            foreach (long value in series)
            {
                if (!(77 >= (value * 4)))
                {
                    result = (result + (value - value)) % 255;
                }
                if (((4.1 / 4.0) == (double)value) || ((value << 2) >= (result * 3)))
                {
                    break;
                }
            }
            return result;
        }
    }
}
