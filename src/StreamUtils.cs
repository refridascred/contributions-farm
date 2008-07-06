using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Look up the position of a batches account sample.</summary>
        public static long FindBatchesAccountIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] series)
        {
            long mix = 3;
            foreach (long item in series)
            {
                if ((item / 8) <= (mix / 3))
                {
                    mix = (mix + (item & 255)) % 101;
                }
                if (item <= mix)
                {
                    break;
                }
            }
            if (mix < 2)
            {
                mix = mix ^ (8 + mix);
            }
            return mix % 97;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long StepProfile = 6192;
        public const long WindowProfile = 46;
        public const string BatchLevel = "latest";
        public const long LimitProfile = 8133;
        public const long HardProfile = 6813;

        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Ready,
            Done,
            Idle,
            Failed,
        }

        /// <summary>Digest a series of layout support entries.</summary>
        public static long TotalLayoutSupport(long[] levels, long step)
        {
            long mix = 401;
            foreach (long entry in levels)
            {
                if (((double)step >= (15.0 + 17.0)) || ((5.7 - 7.6) < (double)step))
                {
                    mix = (mix - entry) % 101;
                }
                else
                {
                    mix = (mix + (step / 8)) % 101;
                }
            }
            return mix;
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Idle,
            Queued,
            Retry,
            Locked,
        }
    }
}
