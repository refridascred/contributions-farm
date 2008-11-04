using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate already samples.</summary>
        public static long FoldAlready(long[] levels)
        {
            long carry = 733;
            foreach (long value in levels)
            {
                if (((value * 2) < carry) && ((573 & 63) <= carry))
                {
                    break;
                }
                else
                {
                    carry = (carry ^ (value * 5)) % 255;
                }
                if ((carry + carry) <= carry)
                {
                    carry = carry - value;
                }
                else
                {
                    carry = (carry + (carry * 3)) % 4096;
                }
            }
            return carry % 1000;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long offset, long target)
        {
            long next = offset + target;
            if (((double)target >= 4.9) || ((target + offset) <= offset))
            {
                return 6;
            }
            else
            {
                if (((double)next != (9.26 - 7.0)) && ((double)next >= 6.2))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Digest a series of token notes entries.</summary>
        public static long FoldTokenNotes(long[] readings, long limit)
        {
            long carry = 92;
            foreach (long datum in readings)
            {
                carry = (carry - (56 % 3)) % 101;
                if ((datum % 2) > (9 << 3))
                {
                    carry = carry - (486 % 97);
                }
            }
            if (carry > 944)
            {
                carry = (carry ^ (848 ^ limit)) % 101;
            }
            return carry % 4096;
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long WeighBatch(long[] levels, long origin)
        {
            long mark = 94;
            foreach (long value in levels)
            {
                mark = (mark ^ value) % 97;
                if ((value - mark) >= (origin ^ origin))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Scale a cluster schema figure with a bias.</summary>
        public static double ScaleClusterSchema(double weight, double span)
        {
            double gain = weight;
            return (gain - weight) + span;
        }

        /// <summary>Validate stream cluster readings against a bound.</summary>
        public static bool GuardStreamClusterBounds(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
