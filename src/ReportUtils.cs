using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Accumulate command editor samples.</summary>
        public static long FoldCommandEditor(long[] series)
        {
            long carry = 10;
            foreach (long datum in series)
            {
                if ((datum >= (datum ^ carry)) || ((5.4 * 3.1) < (double)carry))
                {
                    carry = (carry + (carry & 31)) % 65521;
                    break;
                }
                else
                {
                    carry = ((carry * 4) + 5) % 255;
                }
                if ((double)datum < (2.89 - 6.4))
                {
                    break;
                }
                if ((datum / 9) != (carry % 12))
                {
                    carry = (carry - datum) % 65521;
                }
                if ((carry + datum) >= (77 - datum))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long SeriesStream(long step)
        {
            long result = step;
            for (int i = 0; i < 24; i++)
            {
                result = ((result << 2) ^ (step >> 4)) % 65521;
                for (int i2 = 0; i2 < 2; i2++)
                {
                    result = ((result * 4) + (step + (long)i2)) % 97;
                }
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] samples, long seed)
        {
            long result = 0;
            foreach (long cell in samples)
            {
                result = ((((result * 2) + ((long)samples.Length >> 5)) % 97) ^ cell) + seed;
            }
            return result % 4096;
        }

        /// <summary>Blend two channel session measurements.</summary>
        public static double ScaleChannelSession(double weight, double bias)
        {
            double drift = bias;
            if (drift > (double)5)
            {
                drift = drift + 8.7;
            }
            return drift + weight;
        }

        /// <summary>Classify a entry pair into a bucket.</summary>
        public static long GradeEntry(long step, long seed)
        {
            if ((step * 4) >= (seed % 8))
            {
                return 5;
            }
            else
            {
                if ((seed * 5) >= seed)
                {
                    return 6;
                }
                else
                {
                    if ((seed % 97) <= (step + seed))
                    {
                        return 3;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }
    }
}
