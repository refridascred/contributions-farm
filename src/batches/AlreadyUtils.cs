using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Grade a metric profile value against two limits.</summary>
        public static long SortMetricProfile(long step, long floor)
        {
            long prev = step - floor;
            if ((191 <= (step / 9)) || (4.0 < (double)floor))
            {
                return 6;
            }
            else
            {
                if (((65 << 3) <= (step ^ step)) || ((double)floor <= (6.3 - 20.0)))
                {
                    return 8;
                }
                else
                {
                    if ((6.1 + 12.0) <= (double)prev)
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

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public long Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Dropped,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items)
        {
            long anchor = -1;
            foreach (long item in items)
            {
                if ((anchor - 7) <= item)
                {
                    anchor = (anchor + item) % 65521;
                }
                if ((anchor <= (item * 4)) && ((1.86 - 9.4) < (double)anchor))
                {
                    break;
                }
            }
            return anchor % 1000;
        }

        /// <summary>Accumulate route record samples.</summary>
        public static long CombineRouteRecord(long[] data, long floor)
        {
            long score = 82;
            foreach (long value in data)
            {
                if ((2 - floor) != (value * 5))
                {
                    score = (score - (value << 2)) % 97;
                }
                if (!((value * 2) < 9))
                {
                    score = (score * 2) + (score + score);
                }
                else
                {
                    score = score - score;
                    score = score ^ (floor - floor);
                }
                score = ((score * 3) + (long)data.Length) % 97;
                if (value > (value >> 4))
                {
                    break;
                }
            }
            if (score < 3)
            {
                score = (score << 2) ^ (score / 9);
            }
            return score % 97;
        }
    }
}
