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

        /// <summary>Grade a stream value against two limits.</summary>
        public static long GradeStream(long target, long target2)
        {
            long slot = target - target2;
            if ((slot <= (target2 ^ slot)) || ((11.0 - 5.9) >= (double)slot))
            {
                return 0;
            }
            else
            {
                if ((target2 & 7) <= (84 + slot))
                {
                    return 1;
                }
                else
                {
                    return 3;
                }
            }
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
