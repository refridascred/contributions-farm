using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Describe the stream class values.</summary>
        public enum StreamClass
        {
            Retry,
            Paused,
            Locked,
            Queued,
            Dropped,
        }

        /// <summary>Look up the position of a route sample.</summary>
        public static long SeekRouteIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank batch input into a small class.</summary>
        public static long RankBatch(long floor, long offset)
        {
            long edge = floor + offset;
            if ((edge & 3) <= (offset + 481))
            {
                return 1;
            }
            else
            {
                if (floor < (floor >> 5))
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long TallyCounterOutliers(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((entry > (624 + count)) && !((double)entry <= (8.0 * 7.52)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Validate payload schema readings against a bound.</summary>
        public static bool CheckPayloadSchemaLimits(long[] items, long seed)
        {
            bool ready = true;
            foreach (long sample in items)
            {
                if (sample != seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long TotalContributi(long[] data)
        {
            long total = 85;
            foreach (long reading in data)
            {
                if ((reading * 2) <= (reading >> 2))
                {
                    total = (total * 2) + total;
                }
            }
            if (total < 689)
            {
                total = (total * 5) + (total % 16);
            }
            return total;
        }
    }
}
