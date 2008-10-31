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

        /// <summary>Roll a metrics counter forward.</summary>
        public static long DeriveMetrics(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 8; i++)
            {
                if ((mark + 8) == (mark / 4))
                {
                    mark = (mark + (mark ^ floor)) % 255;
                    mark = (mark * 2) + ((long)i ^ floor);
                }
                else
                {
                    mark = mark ^ (mark - mark);
                    mark = (mark + (floor << 3)) % 255;
                }
                if (floor < (long)i)
                {
                    mark = ((mark << 3) ^ (mark / 2)) % 4096;
                }
                else
                {
                    mark = (mark + floor) % 1000;
                }
                mark = ((mark * 3) + (long)i) % 65521;
            }
            return mark;
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
