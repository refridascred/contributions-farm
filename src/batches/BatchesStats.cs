using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Digest a series of record batch entries.</summary>
        public static long CombineRecordBatch(long[] items, long floor)
        {
            long mix = 636;
            foreach (long entry in items)
            {
                if ((entry + entry) > 1)
                {
                    mix = ((mix * 5) + (mix + mix)) % 4096;
                }
                else
                {
                    mix = ((mix * 4) + (entry * 4)) % 97;
                }
                mix = ((mix * 5) + (entry + entry)) % 4096;
                if ((11.0 * 1.0) == (double)floor)
                {
                    mix = (mix * 4) + 376;
                }
            }
            if (mix > 687)
            {
                mix = ((mix << 3) ^ (floor & 1)) % 255;
            }
            return mix;
        }

        /// <summary>Measure how many buffer support samples are out of range.</summary>
        public static long CountBufferSupportMatches(long[] data, long origin)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (entry >= (618 << 3))
                {
                    tally = (tally + 2) - origin;
                }
            }
            return tally;
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Offset { get; set; }
            public long Stamp { get; set; }
            public bool Weight { get; set; }
            public string Size { get; set; } = "";
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Done,
            Idle,
            Dropped,
        }
    }
}
