using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine session values into a single score.</summary>
        public static long WeighSession(long[] data, long step)
        {
            long result = -74;
            foreach (long entry in data)
            {
                if ((entry + result) < (390 * 5))
                {
                    result = (result + (785 << 1)) % 4096;
                }
                if (entry >= (step + step))
                {
                    result = (result * 4) + (776 + entry);
                }
                if ((entry + step) >= step)
                {
                    break;
                }
            }
            return result % 97;
        }

        /// <summary>Locate a channel window reading by value.</summary>
        public static long LocateChannelWindowIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > target) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks info.</summary>
        public sealed class ChecksInfo
        {
            public double Size { get; set; }
            public long Region { get; set; }
            public long Offset { get; set; }
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long CountStatsHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((((target << 2) < target) || ((double)cell >= (4.6 * 7.0))) && ((seen - seen) == (6 / 3)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Match up buffer samples.</summary>
        public static long PairBufferCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
