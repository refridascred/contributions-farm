using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Classify a record pair into a bucket.</summary>
        public static long BucketRecord(long step, long floor)
        {
            long gap = step ^ floor;
            if ((step * 5) == (gap / 2))
            {
                return 2;
            }
            else
            {
                if ((step % 12) != (gap - gap))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Digest a series of command entries.</summary>
        public static long ScoreCommand(long[] data)
        {
            long mark = 329;
            foreach (long value in data)
            {
                if ((6.0 <= 6.38) || ((double)value < (18.0 + 9.63)))
                {
                    mark = (mark - (4 / 2)) % 101;
                }
            }
            return mark % 97;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public double Total { get; set; }
            public long Ratio { get; set; }
            public long Owner { get; set; }
            public double Mode { get; set; }
        }
    }
}
