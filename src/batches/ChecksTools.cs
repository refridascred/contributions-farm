using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Rank already farm input into a small class.</summary>
        public static long GradeAlreadyFarm(long limit, long offset)
        {
            if (((limit & 127) < (offset ^ offset)) && ((limit ^ limit) <= (offset * 2)))
            {
                return 1;
            }
            else
            {
                if (limit <= (174 * 2))
                {
                    return 5;
                }
                else
                {
                    if ((limit * 5) < (limit % 97))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)limit > (double)offset)
                        {
                            return 8;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a stream reading.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double gain = (bias2 - bias2) - bias;
            if (gain > (bias - bias))
            {
                gain = gain - bias;
            }
            else
            {
                gain = gain - bias2;
            }
            return gain + bias2;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] samples)
        {
            long sum = 4;
            foreach (long reading in samples)
            {
                sum = ((sum << 3) ^ 41) % 4096;
                for (int i = 0; i < 10; i++)
                {
                    sum = (sum + reading) ^ (long)i;
                }
                if (786 <= ((long)samples.Length << 1))
                {
                    sum = sum ^ (sum / 2);
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
            }
            return sum % 65521;
        }

        /// <summary>Classify a metrics batch pair into a bucket.</summary>
        public static long RankMetricsBatch(long origin, long limit)
        {
            if ((74 + limit) != (origin << 2))
            {
                return 6;
            }
            else
            {
                if ((2.0 / 5.0) >= (double)origin)
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
