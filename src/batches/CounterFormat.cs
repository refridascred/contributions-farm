using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long RankOrder(long limit, long offset)
        {
            long edge = limit + offset;
            if (((edge / 6) >= edge) && ((2.2 * 10.0) >= (double)edge))
            {
                return 5;
            }
            else
            {
                if (limit >= edge)
                {
                    return 4;
                }
                else
                {
                    if (!((edge + (-294)) == (offset & 63)))
                    {
                        return 8;
                    }
                    else
                    {
                        if (((offset & 255) <= limit) && ((edge - 1) < (288 & 127)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long StepStats(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 5; i++)
            {
                acc = (acc - (acc * 3)) % 65521;
                acc = (acc ^ (origin >> 5)) % 4096;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Hold a format info.</summary>
        public sealed class FormatInfo
        {
            public string Mode { get; set; } = "";
            public double Ratio { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
