using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first layout entry that matches the target.</summary>
        public static long LocateLayoutIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= target) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public long Stamp { get; set; }
            public long Count { get; set; }
            public long Ratio { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Grade a batches graph value against two limits.</summary>
        public static long BucketBatchesGraph(long origin, long step)
        {
            long step2 = origin - step;
            if ((step % 16) != (step2 - step))
            {
                return 4;
            }
            else
            {
                if ((double)step2 >= (2.4 - 2.26))
                {
                    return 3;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double WindowLevel = 66.44;
        public const string MinSupport = "cached";
        public const long IdleSupport = 6848;
    }
}
