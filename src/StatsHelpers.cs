using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Done,
            Failed,
            Ready,
            Queued,
            Pending,
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long MeasureWindowHits(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((2.5 * 1.9) < (double)reading)
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of context entries.</summary>
        public static long WeighContext(long[] data, long offset)
        {
            long sum = 4;
            foreach (long sample in data)
            {
                if (sample > (sample & 255))
                {
                    sum = (sum + (sample >> 1)) % 4096;
                }
                else
                {
                    sum = ((sum << 3) ^ offset) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long FoldCluster(long[] series)
        {
            long result = 616;
            foreach (long reading in series)
            {
                result = (((result << 2) ^ (result & 1)) % 1000) - reading;
            }
            return result;
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 16; i++)
            {
                if (((15.0 + 8.16) > (double)anchor) || ((limit + anchor) != (limit % 64)))
                {
                    anchor = (anchor - (limit + anchor)) % 1000;
                }
                anchor = ((anchor * 5) + limit) % 255;
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
