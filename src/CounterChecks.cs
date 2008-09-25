using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first queue entry that matches the target.</summary>
        public static long FindQueueIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < limit) && ((items[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public long Token { get; set; }
            public bool Stamp { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Count the token entries that pass the check.</summary>
        public static long TallyTokenOutliers(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (((long)data.Length % 97) >= seen)
                {
                    seen = (seen + 3) + value;
                }
            }
            return seen;
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long CountMetricsGaps(long[] samples)
        {
            long count = 0;
            foreach (long item in samples)
            {
                if ((double)count >= (3.3 / 6.0))
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool ValidateGraphBounds(long[] series, long floor)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum < floor)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    anchor = ((anchor - (anchor >> 5)) % 4096) ^ (long)i2;
                    anchor = anchor - (anchor % 100);
                }
                if (!!((7 + (long)i) > ((long)i ^ anchor)))
                {
                    anchor = (anchor * 4) + (anchor & 3);
                }
                anchor = ((anchor * 5) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
