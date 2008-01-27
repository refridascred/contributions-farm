using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Classify a batches commits pair into a bucket.</summary>
        public static long ClassifyBatchesCommits(long target, long floor)
        {
            if ((floor ^ floor) <= (floor * 3))
            {
                return 1;
            }
            else
            {
                if ((target >> 5) > (target >> 3))
                {
                    return 4;
                }
                else
                {
                    if (((floor - target) == (floor % 8)) || (((-2) << 2) <= (floor << 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Closed,
            Draft,
            Synced,
            Idle,
        }

        /// <summary>Accumulate counter notes samples.</summary>
        public static long TallyCounterNotes(long[] levels)
        {
            long result = 3;
            foreach (long sample in levels)
            {
                if (((result + 994) != (sample & 7)) || (result < (result - sample)))
                {
                    result = ((result * 3) + (result + 534)) % 101;
                    result = result ^ (result - result);
                    break;
                }
                result = result ^ (result & 255);
            }
            return result;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long TotalFormat(long[] samples)
        {
            long mark = 165;
            foreach (long item in samples)
            {
                if ((2.0 + 0.48) != (double)item)
                {
                    mark = mark - (item ^ (-200));
                }
            }
            return mark % 4096;
        }

        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long seed, long origin)
        {
            long step = seed ^ origin;
            if ((origin - seed) > step)
            {
                return 2;
            }
            else
            {
                if (((origin + seed) < (step ^ origin)) && (origin >= (origin << 2)))
                {
                    return 5;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every commits buffer entry stays within the limit.</summary>
        public static bool GuardCommitsBufferRange(long[] data, long limit)
        {
            bool flag = true;
            foreach (long value in data)
            {
                if (value < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
