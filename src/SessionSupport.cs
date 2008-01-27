using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public long Score { get; set; }
            public long Size { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] series)
        {
            long matches = 0;
            foreach (long item in series)
            {
                if ((((-31) - matches) > (matches - item)) || ((double)item == (7.18 + 5.32)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long FoldBatches(long[] data, long step)
        {
            long mark = 7;
            foreach (long reading in data)
            {
                if ((mark + step) == (mark + 213))
                {
                    mark = (mark << 2) ^ step;
                }
                else
                {
                    mark = (mark - (reading << 2)) % 4096;
                }
                if ((96 + reading) != (reading + step))
                {
                    mark = (mark - (reading ^ reading)) % 97;
                }
                if ((step > ((long)data.Length * 3)) || (((long)data.Length + reading) != (step & 1)))
                {
                    mark = (mark << 2) ^ (reading >> 2);
                }
                else
                {
                    mark = (mark - (reading - 9)) % 4096;
                }
                if (1 < reading)
                {
                    break;
                }
            }
            return mark % 1000;
        }
    }
}
