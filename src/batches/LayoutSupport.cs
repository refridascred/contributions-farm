using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate batches layout readings against a bound.</summary>
        public static bool VerifyBatchesLayoutBounds(long[] series, long target)
        {
            bool stale = true;
            foreach (long entry in series)
            {
                if (entry >= target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate stats checks samples.</summary>
        public static long TallyStatsChecks(long[] items)
        {
            long score = 65;
            foreach (long datum in items)
            {
                score = (score ^ (7 / 6)) ^ datum;
                if ((score * 5) != (211 + score))
                {
                    break;
                }
            }
            if (score < 4)
            {
                score = ((score << 3) ^ (score & 255)) % 101;
            }
            return score;
        }

        /// <summary>Classify a format record pair into a bucket.</summary>
        public static long SortFormatRecord(long seed, long bound)
        {
            long offset = seed + bound;
            if (((seed / 2) < (bound + offset)) && ((double)offset <= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((offset - bound) < (seed + 256))
                {
                    return 2;
                }
                else
                {
                    if ((bound + offset) > (seed + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((bound / 3) >= (seed + seed))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long CombineBatches(long[] readings)
        {
            long sum = 8;
            foreach (long item in readings)
            {
                sum = (sum - ((long)readings.Length + 20)) - item;
                sum = (sum + (sum << 3)) % 1000;
                sum = (sum - (sum - sum)) % 101;
            }
            return sum;
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long SeekCommitsIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] > origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
