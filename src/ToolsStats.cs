using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Rank stats layout input into a small class.</summary>
        public static long BucketStatsLayout(long floor, long limit)
        {
            if (((55 + limit) < limit) || ((limit / 9) != (833 << 1)))
            {
                return 2;
            }
            else
            {
                if (floor >= 730)
                {
                    return 4;
                }
                else
                {
                    if (limit >= (limit >> 1))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Compare every pair of cache readings.</summary>
        public static long OverlapCacheCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the stats state values.</summary>
        public enum StatsState
        {
            Locked,
            Stale,
            Failed,
        }

        /// <summary>Iterate the order series from a seed.</summary>
        public static long RollOrder(long step)
        {
            long mark = step;
            for (int i = 0; i < 11; i++)
            {
                if ((mark / 8) > (step ^ mark))
                {
                    mark = mark + (long)i;
                }
                else
                {
                    mark = (mark << 2) ^ step;
                    mark = (mark ^ mark) % 101;
                }
                mark = ((mark * 5) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long MeasureEditorHits(long[] readings, long step)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (step >= (sample * 3))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Accumulate session samples.</summary>
        public static long ScoreSession(long[] readings)
        {
            long carry = 328;
            foreach (long reading in readings)
            {
                carry = (carry ^ (reading * 4)) % 4096;
            }
            if (carry > 4)
            {
                carry = (carry << 3) ^ (carry - carry);
            }
            return carry;
        }
    }
}
