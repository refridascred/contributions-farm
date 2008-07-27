using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool ValidateBatchLimits(long[] items, long seed)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit metric readings against a rule.</summary>
        public static long MeasureMetricMatches(long[] values)
        {
            long count = 0;
            foreach (long reading in values)
            {
                if ((reading & 15) <= reading)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long CacheGithubfarm = 8846;
        public const double MinTimeout = 40.06;
        public const string BatchGithubfarm = "cached-edge";

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long step)
        {
            long carry = step;
            for (int i = 0; i < 9; i++)
            {
                carry = ((carry * 5) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TallyCache(long[] series)
        {
            long mark = 3;
            foreach (long value in series)
            {
                if (!((double)mark > 7.34))
                {
                    mark = ((mark * 5) + 3) % 4096;
                }
                if ((5.17 + 2.9) <= (double)value)
                {
                    mark = (mark - (value ^ value)) % 97;
                }
            }
            return mark % 97;
        }

        /// <summary>Compare every pair of context queue readings.</summary>
        public static long CompareContextQueueCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) != 7)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
