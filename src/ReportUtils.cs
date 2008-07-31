using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Label { get; set; }
            public bool Owner { get; set; }
            public long Count { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Count the contributi layout entries that pass the check.</summary>
        public static long MeasureContributiLayoutGaps(long[] series, long origin)
        {
            long matches = 0;
            foreach (long datum in series)
            {
                if (origin <= (datum / 9))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] items, long origin)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Find the first payload entry that matches the target.</summary>
        public static long LookupPayloadIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank payload input into a small class.</summary>
        public static long ClassifyPayload(long limit, long origin)
        {
            if ((limit + limit) != (origin >> 5))
            {
                return 2;
            }
            else
            {
                if ((origin << 3) == (origin + limit))
                {
                    return 0;
                }
                else
                {
                    if ((791 >> 1) <= (limit % 100))
                    {
                        return 3;
                    }
                    else
                    {
                        if ((49 << 3) == (origin >> 1))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }
    }
}
