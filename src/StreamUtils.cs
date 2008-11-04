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

        /// <summary>Roll a editor counter forward.</summary>
        public static long DeriveEditor(long step)
        {
            long score = step;
            for (int i = 0; i < 20; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score + ((long)i2 - (-947))) % 65521;
                    score = ((score << 3) ^ (step + step)) % 1000;
                }
                if (!((long)i <= (step + score)))
                {
                    score = (score * 3) + 799;
                }
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
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
