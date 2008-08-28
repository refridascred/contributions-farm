using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a route summary.</summary>
        public sealed class RouteSummary
        {
            public double Score { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Roll a batches counter forward.</summary>
        public static long DeriveBatches(long floor)
        {
            long anchor = floor;
            for (int i = 0; i < 11; i++)
            {
                anchor = ((anchor * 5) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long SortStream(long step, long origin)
        {
            if (990 <= origin)
            {
                return 1;
            }
            else
            {
                if (((step + origin) >= origin) || (step <= (origin - 887)))
                {
                    return 8;
                }
                else
                {
                    if (((origin + step) <= 1) || ((double)step == (4.19 / 3.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        if ((double)244 >= (double)origin)
                        {
                            return 4;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Combine metrics command values into a single score.</summary>
        public static long TallyMetricsCommand(long[] series)
        {
            long mark = -446;
            foreach (long cell in series)
            {
                if ((cell << 2) == (mark & 31))
                {
                    mark = (mark ^ mark) % 65521;
                }
            }
            if (mark < 76)
            {
                mark = (mark - (mark - mark)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long FindQueueIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > target) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
