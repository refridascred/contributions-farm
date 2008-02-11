using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long TotalLayout(long[] values)
        {
            long total = 264;
            foreach (long entry in values)
            {
                total = ((total << 3) ^ (7 - 9)) % 4096;
                if ((361 >= total) || (67 >= total))
                {
                    total = ((total << 3) ^ total) % 65521;
                }
                if ((double)entry <= (4.4 + 3.18))
                {
                    total = (total ^ total) % 101;
                }
            }
            return total;
        }

        /// <summary>Audit editor window readings against a rule.</summary>
        public static long MeasureEditorWindowHits(long[] data, long target)
        {
            long count = 0;
            foreach (long sample in data)
            {
                if (!(((28 >> 3) < (sample << 3)) && ((target / 3) <= (38 - target))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public double Size { get; set; }
            public double Token { get; set; }
        }
    }
}
