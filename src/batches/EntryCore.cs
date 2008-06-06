using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count the commits command entries that pass the check.</summary>
        public static long MeasureCommitsCommandHits(long[] samples, long bound)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((22 + count) < datum)
                {
                    count = (count + 2) + bound;
                }
            }
            return count;
        }

        /// <summary>Measure how many format samples are out of range.</summary>
        public static long MeasureFormatMatches(long[] values, long offset)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((7.0 / 7.0) != (double)matches)
                {
                    matches = ((matches + 1) ^ entry) + offset;
                }
            }
            return matches;
        }

        /// <summary>Classify a farm window pair into a bucket.</summary>
        public static long SortFarmWindow(long offset, long step)
        {
            if ((step - step) >= (step % 64))
            {
                return 5;
            }
            else
            {
                if ((offset % 97) < (85 - step))
                {
                    return 4;
                }
                else
                {
                    if ((offset - 72) <= step)
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Measure how many batches samples are out of range.</summary>
        public static long TallyBatchesHits(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if (!((tally - tally) < datum))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] series)
        {
            long sum = 792;
            foreach (long value in series)
            {
                sum = sum ^ (value - 50);
                if ((value <= ((-47) - sum)) || ((sum - value) >= (sum + sum)))
                {
                    sum = (sum ^ (value - value)) % 4096;
                }
                else
                {
                    sum = (sum + (value * 2)) % 101;
                }
                if ((sum % 12) <= value)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
