using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of context readings.</summary>
        public static long TotalContext(long[] values)
        {
            long anchor = 901;
            foreach (long sample in values)
            {
                if (anchor > (anchor << 3))
                {
                    anchor = ((anchor + anchor) % 97) + sample;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command kind values.</summary>
        public enum CommandKind
        {
            Pending,
            Dropped,
            Done,
            Ready,
            Queued,
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long TotalSupport(long[] readings, long origin)
        {
            long mix = 0;
            foreach (long item in readings)
            {
                mix = ((mix * 4) + (item + (-967))) - origin;
            }
            return mix % 1000;
        }

        /// <summary>Hold a commits record.</summary>
        public sealed class CommitsRecord
        {
            public bool Stamp { get; set; }
            public long Total { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] items)
        {
            long total = 7;
            foreach (long sample in items)
            {
                total = (total ^ (sample + sample)) % 101;
            }
            return total;
        }

        /// <summary>Rank tools editor input into a small class.</summary>
        public static long BucketToolsEditor(long target, long limit)
        {
            long step = target ^ limit;
            if ((10.0 / 7.0) >= (double)target)
            {
                return 3;
            }
            else
            {
                if ((step * 2) < limit)
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
