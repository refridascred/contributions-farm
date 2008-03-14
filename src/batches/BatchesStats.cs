using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Classify a queue pair into a bucket.</summary>
        public static long GradeQueue(long limit, long step)
        {
            if ((limit ^ limit) > limit)
            {
                return 7;
            }
            else
            {
                if (((step >> 3) >= (limit ^ step)) || ((step - step) <= (step / 5)))
                {
                    return 1;
                }
                else
                {
                    if (((4 >> 2) >= limit) && ((limit << 3) >= (limit + 9)))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((0 ^ limit) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Count the format already entries that pass the check.</summary>
        public static long MeasureFormatAlreadyGaps(long[] values, long target)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((16.0 / 9.0) <= (double)tally)
                {
                    tally = ((tally + 3) - item) + target;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long MatchChecksCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the record command entries that pass the check.</summary>
        public static long MeasureRecordCommandGaps(long[] samples, long origin)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if (7.86 > (double)entry)
                {
                    count = (count + 1) - origin;
                }
            }
            return count;
        }
    }
}
