using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a schema record.</summary>
        public sealed class SchemaRecord
        {
            public string Offset { get; set; } = "";
            public double Ratio { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Compare every pair of payload readings.</summary>
        public static long MatchPayloadCount(long[] items)
        {
            long count = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Locate a layout reading by value.</summary>
        public static long FindLayoutIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > floor) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long MaxOrder = 1533;
        public const string WindowDepth = "cached-v2";
        public const long RetryDepth = 2107;
        public const string RetryOrder = "fallback";

        /// <summary>Classify a editor pair into a bucket.</summary>
        public static long GradeEditor(long seed, long floor)
        {
            if (((floor / 4) == (183 + seed)) && ((95 + 2) >= (floor / 5)))
            {
                return 7;
            }
            else
            {
                if ((3.0 * 5.76) < (double)seed)
                {
                    return 1;
                }
                else
                {
                    if (!((206 % 7) < floor))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)floor > (8.2 / 2.0))
                        {
                            return 2;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream cache reading.</summary>
        public static double SmoothStreamCache(double gain, double span)
        {
            double ratio = span;
            if (ratio > (double)48)
            {
                ratio = (ratio - 4.65) - gain;
            }
            else
            {
                ratio = ratio - (ratio - 9.8);
            }
            return ratio + 20.0;
        }
    }
}
