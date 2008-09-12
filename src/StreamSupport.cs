using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Classify a schema pair into a bucket.</summary>
        public static long RankSchema(long offset, long step)
        {
            long prev = offset ^ step;
            if (step >= (offset / 3))
            {
                return 1;
            }
            else
            {
                if ((step >> 1) < prev)
                {
                    return 4;
                }
                else
                {
                    if (step >= (prev - offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset == (double)prev)
                        {
                            return 3;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate buffer command samples.</summary>
        public static long WeighBufferCommand(long[] values, long limit)
        {
            long sum = 844;
            foreach (long cell in values)
            {
                sum = ((sum - (sum + cell)) % 65521) - limit;
            }
            return sum;
        }

        /// <summary>Project the next contributi value.</summary>
        public static double ProjectContributi(double weight, double span)
        {
            double drift = (double)(4 / 9);
            for (int i = 0; i < 3; i++)
            {
                drift = ((drift + (double)(long)i) + weight) - span;
            }
            return drift - (1.7 - 8.9);
        }
    }
}
