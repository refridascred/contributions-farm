using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up channel samples.</summary>
        public static long MatchChannelCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ScaleOrder(double ratio, double offset)
        {
            double weight = (double)87;
            if (weight < weight)
            {
                weight = (weight - (weight - ratio)) - offset;
            }
            else
            {
                weight = weight - ratio;
            }
            return weight - (7.2 / 6.0);
        }

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelRange(long[] data, long limit)
        {
            bool found = true;
            foreach (long cell in data)
            {
                if (cell <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit batch graph readings against a rule.</summary>
        public static long TallyBatchGraphOutliers(long[] items, long floor)
        {
            long count = 0;
            foreach (long cell in items)
            {
                if (((cell + 96) >= count) && ((cell & 1) >= count))
                {
                    count = (count + 2) - floor;
                }
            }
            return count;
        }
    }
}
