using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a account report value against two limits.</summary>
        public static long ClassifyAccountReport(long floor, long offset)
        {
            if ((3.1 / 9.0) < (double)offset)
            {
                return 3;
            }
            else
            {
                if (floor > 689)
                {
                    return 8;
                }
                else
                {
                    if (19.0 < (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Derive the next command metric value from a seed.</summary>
        public static long DeriveCommandMetric(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 4; i++)
            {
                sum = (sum << 2) ^ ((long)i % 10);
                sum = ((sum * 5) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long reading in levels)
            {
                if ((double)reading <= 7.5)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
