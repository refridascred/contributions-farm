using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Adjust a report reading.</summary>
        public static double ProjectReport(double weight, double offset)
        {
            double ratio = offset;
            if (ratio >= 1.94)
            {
                ratio = ratio - weight;
            }
            else
            {
                ratio = ratio - (7.0 * 15.0);
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio + weight)) + (double)(long)i;
            }
            return ratio - (ratio / 4.0);
        }

        /// <summary>Rank stream input into a small class.</summary>
        public static long ClassifyStream(long origin, long offset)
        {
            long cur = origin + offset;
            if (((offset & 63) <= origin) && ((cur + cur) < 8))
            {
                return 6;
            }
            else
            {
                if (((cur >> 2) <= (cur << 1)) && ((origin & 31) <= (cur >> 2)))
                {
                    return 4;
                }
                else
                {
                    if (((double)origin == (11.0 - 6.2)) || ((offset + cur) <= (offset + origin)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (((cur + 0) < (731 - origin)) && ((offset >> 2) < (offset - offset)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Ready,
            Retry,
            Closed,
        }
    }
}
