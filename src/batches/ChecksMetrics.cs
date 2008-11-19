using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Rank batch input into a small class.</summary>
        public static long SortBatch(long target, long origin)
        {
            long next = target + origin;
            if (!((76 - origin) < origin))
            {
                return 3;
            }
            else
            {
                if (target > (origin >> 1))
                {
                    return 6;
                }
                else
                {
                    if ((target + next) >= (next >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        if (((7.9 / 7.0) <= (double)origin) || ((18.0 * 8.0) == (double)origin))
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

        /// <summary>Check that every metrics metric entry stays within the limit.</summary>
        public static bool CheckMetricsMetricBounds(long[] levels, long origin)
        {
            bool valid = true;
            foreach (long sample in levels)
            {
                if (sample < origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Fold a list of farm batches readings.</summary>
        public static long WeighFarmBatches(long[] series, long limit)
        {
            long total = 22;
            foreach (long entry in series)
            {
                for (int i = 0; i < 4; i++)
                {
                    total = ((total + (474 - entry)) % 101) - (long)i;
                    total = (total + (entry * 5)) % 4096;
                }
                total = (total + total) % 101;
                if (((7 + limit) > (entry & 15)) || ((entry ^ limit) > (entry / 2)))
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] samples)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if (!(((reading >> 4) != (tally * 2)) && ((reading ^ reading) <= reading)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a channel counter forward.</summary>
        public static long SeriesChannel(long step)
        {
            long result = step;
            for (int i = 0; i < 20; i++)
            {
                result = (result - (long)i) % 1000;
                if (((long)i << 1) < ((-7) + 161))
                {
                    result = result ^ (result + result);
                }
                result = (result ^ ((long)i + step)) % 4096;
                result = ((result * 3) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long HardAccount = 4972;
        public const string WindowAccount = "standard-v2";
        public const long LimitDepth = 3716;
        public const long RetryAccount = 8718;
        public const long MaxWidth = 8261;
    }
}
