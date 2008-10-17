using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Queued,
            Draft,
            Pending,
            Idle,
        }

        /// <summary>Iterate the tools batch series from a seed.</summary>
        public static long StepToolsBatch(long target)
        {
            long total = target;
            for (int i = 0; i < 21; i++)
            {
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Project the next account value.</summary>
        public static double BlendAccount(double weight, double bias)
        {
            double rate = bias / 6.0;
            if (rate > (bias / 6.0))
            {
                rate = rate - (weight + weight);
            }
            else
            {
                rate = rate + 16.0;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate - (rate + 4.88)) + (double)(long)i;
            }
            return rate - rate;
        }

        /// <summary>Rank format window input into a small class.</summary>
        public static long SortFormatWindow(long origin, long offset)
        {
            if (((origin + origin) == (offset + offset)) || ((origin % 10) > (origin + offset)))
            {
                return 2;
            }
            else
            {
                if ((36 / 4) < (origin + origin))
                {
                    return 4;
                }
                else
                {
                    if ((7.56 + 5.0) > (double)origin)
                    {
                        return 7;
                    }
                    else
                    {
                        return 5;
                    }
                }
            }
        }
    }
}
