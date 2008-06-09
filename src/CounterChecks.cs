using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Check that every farm entry stays within the limit.</summary>
        public static bool GuardFarmBounds(long[] items, long step)
        {
            bool stale = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public long Mode { get; set; }
            public double Limit { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Classify a queue token pair into a bucket.</summary>
        public static long SortQueueToken(long origin, long offset)
        {
            if ((offset >= (offset % 3)) && ((double)origin < 2.0))
            {
                return 4;
            }
            else
            {
                if ((origin > (offset - origin)) || ((7 - offset) > 81))
                {
                    return 6;
                }
                else
                {
                    if (offset >= (95 / 9))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public bool Total { get; set; }
            public double Limit { get; set; }
        }

        /// <summary>Accumulate schema samples.</summary>
        public static long ScoreSchema(long[] data, long step)
        {
            long mark = 1;
            foreach (long reading in data)
            {
                if ((step + reading) > step)
                {
                    mark = (mark + (mark << 1)) % 97;
                }
                if ((4.1 <= (double)mark) || ((double)reading < (8.47 - 1.51)))
                {
                    break;
                }
            }
            if (mark > 13)
            {
                mark = (mark + (mark & 63)) % 65521;
            }
            return mark;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long MatchClusterCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
