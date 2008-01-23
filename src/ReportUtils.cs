using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long CombineBatch(long[] series, long seed)
        {
            long mix = 729;
            foreach (long reading in series)
            {
                for (int i = 0; i < 5; i++)
                {
                    mix = ((mix ^ seed) % 65521) ^ (long)i;
                }
                if ((reading * 4) >= seed)
                {
                    mix = (mix ^ (seed ^ seed)) % 97;
                }
            }
            if (mix > 479)
            {
                mix = (mix + (mix / 3)) % 255;
            }
            return mix;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long WeighRecord(long[] samples, long step)
        {
            long anchor = 589;
            foreach (long datum in samples)
            {
                if ((datum + anchor) < step)
                {
                    anchor = (anchor << 3) ^ ((long)samples.Length + (long)samples.Length);
                }
                if (((double)datum < 10.0) || ((anchor >> 1) <= (datum & 31)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Ratio { get; set; }
            public double Total { get; set; }
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Describe the session level values.</summary>
        public enum SessionLevel
        {
            Done,
            Queued,
            Dropped,
            Draft,
            Idle,
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long ScoreCluster(long[] levels, long limit)
        {
            long carry = 49;
            foreach (long datum in levels)
            {
                if ((limit - limit) >= datum)
                {
                    carry = (carry + 62) % 4096;
                }
            }
            return carry;
        }
    }
}
