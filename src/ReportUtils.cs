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

        /// <summary>Validate channel readings against a bound.</summary>
        public static bool ValidateChannelLimits(long[] values, long target)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
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

        /// <summary>Locate a checks reading by value.</summary>
        public static long SeekChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
