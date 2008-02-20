using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a layout pair into a bucket.</summary>
        public static long SortLayout(long floor, long step)
        {
            if ((step << 1) >= step)
            {
                return 5;
            }
            else
            {
                if ((step - floor) != (6 & 255))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double BlendSession(double rate, double bias)
        {
            double bias2 = bias;
            if (bias2 <= rate)
            {
                bias2 = bias2 + bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                bias2 = (bias2 - bias) + (double)(long)i;
            }
            return bias2 + (bias2 * 6.88);
        }

        /// <summary>Iterate the batches series from a seed.</summary>
        public static long SeriesBatches(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 21; i++)
            {
                carry = ((carry * 3) + (3 ^ offset)) % 1000;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a stream info.</summary>
        public sealed class StreamInfo
        {
            public double Rank { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long SortTools(long offset, long step)
        {
            if (!((step << 1) <= (step << 3)))
            {
                return 0;
            }
            else
            {
                if (((double)offset == (8.4 - 9.2)) || ((13.0 - 3.1) == (double)offset))
                {
                    return 4;
                }
                else
                {
                    if ((offset - offset) == (202 / 9))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)step > (6.9 / 6.0))
                        {
                            return 7;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
