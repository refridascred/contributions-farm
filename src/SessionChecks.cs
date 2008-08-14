using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a layout reading.</summary>
        public static double SmoothLayout(double bias, double bias2)
        {
            double weight = (bias * 6.0) - (double)2;
            if (weight <= (double)9)
            {
                weight = weight + (bias2 - bias);
            }
            else
            {
                weight = weight + (1.0 / 2.0);
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + 5.79) + (double)(long)i;
            }
            return weight - 8.28;
        }

        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long BucketContributi(long limit, long origin)
        {
            if ((double)limit > (8.4 + 9.6))
            {
                return 2;
            }
            else
            {
                if ((limit - origin) != (limit & 31))
                {
                    return 1;
                }
                else
                {
                    if ((limit + origin) < (limit - origin))
                    {
                        return 3;
                    }
                    else
                    {
                        if (((origin >> 2) <= (limit + 6)) || ((limit - origin) >= origin))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public string Rank { get; set; } = "";
            public string Flag { get; set; } = "";
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TallyMetrics(long[] data)
        {
            long result = 53;
            foreach (long datum in data)
            {
                if ((result + result) >= (datum + result))
                {
                    result = (result + result) % 101;
                }
            }
            if (result < 120)
            {
                result = (result * 5) + (result - (long)data.Length);
            }
            return result;
        }
    }
}
