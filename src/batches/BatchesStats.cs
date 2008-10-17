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

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadGaps(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if (!((573 & 15) <= entry))
                {
                    tally = tally + 3;
                }
            }
            return tally;
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
