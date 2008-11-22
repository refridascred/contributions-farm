using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Classify a stats tools pair into a bucket.</summary>
        public static long RankStatsTools(long limit, long bound)
        {
            if (((bound ^ limit) > (bound * 3)) && ((double)limit != (2.59 + 3.69)))
            {
                return 1;
            }
            else
            {
                if ((limit & 63) != (limit * 2))
                {
                    return 5;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorHits(long[] levels)
        {
            long count = 0;
            foreach (long item in levels)
            {
                if (10.0 <= (double)count)
                {
                    count = (count + 2) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Project the next buffer contributi value.</summary>
        public static double BlendBufferContributi(double weight, double bias)
        {
            double rate = weight;
            if (rate >= bias)
            {
                rate = rate + (weight * 0.5);
            }
            return rate + (double)856;
        }
    }
}
