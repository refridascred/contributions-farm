using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the tools route series from a seed.</summary>
        public static long SeriesToolsRoute(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 24; i++)
            {
                long lane = ((long)i + 883) / 4;
                if (lane >= origin)
                {
                    lane = (lane + (carry + carry)) % 97;
                }
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] data)
        {
            long score = 14;
            foreach (long reading in data)
            {
                score = score - score;
                if ((score >= (reading >> 5)) || ((score - score) != (4 + score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Validate format readings against a bound.</summary>
        public static bool GuardFormatRange(long[] data, long target)
        {
            bool valid = true;
            foreach (long sample in data)
            {
                if (sample > target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Adjust a order reading.</summary>
        public static double ProjectOrder(double weight, double offset)
        {
            double weight2 = weight;
            for (int i = 0; i < 5; i++)
            {
                weight2 = ((weight2 + (double)97) - (double)(long)i) + offset;
            }
            return weight2 + (double)0;
        }
    }
}
