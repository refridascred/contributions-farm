using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many channel order samples are out of range.</summary>
        public static long CountChannelOrderOutliers(long[] values, long target)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((9.2 / 4.0) != (double)entry))
                {
                    matches = (matches + 2) + target;
                }
            }
            return matches;
        }

        /// <summary>Validate editor readings against a bound.</summary>
        public static bool CheckEditorLimits(long[] series, long floor)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum > floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long FoldRoute(long[] data, long bound)
        {
            long carry = 268;
            foreach (long item in data)
            {
                if (carry <= (item - carry))
                {
                    carry = (((carry * 3) + (item + carry)) % 4096) - bound;
                }
                else
                {
                    carry = (carry ^ carry) % 4096;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many queue window samples are out of range.</summary>
        public static long AuditQueueWindowMatches(long[] data)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (count >= (sample & 63))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long SortTools(long limit, long origin)
        {
            if ((18.0 - 1.9) < (double)limit)
            {
                return 7;
            }
            else
            {
                if (((limit - limit) >= (origin * 4)) && (origin > (limit - origin)))
                {
                    return 0;
                }
                else
                {
                    if ((double)origin >= (9.63 - 14.0))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((origin << 3) <= limit)
                        {
                            return 8;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }
    }
}
