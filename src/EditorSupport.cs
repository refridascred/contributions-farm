using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Derive the next window value from a seed.</summary>
        public static long RollWindow(long step)
        {
            long anchor = step;
            for (int i = 0; i < 5; i++)
            {
                anchor = ((anchor << 2) ^ (anchor * 4)) % 101;
                if ((55 >= (long)i) || (((long)i - (long)i) > ((long)i + 28)))
                {
                    anchor = ((anchor << 2) ^ (step % 16)) % 97;
                    anchor = (anchor + (step << 1)) % 101;
                }
                anchor = ((anchor * 4) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the filter level values.</summary>
        public enum FilterLevel
        {
            Retry,
            Idle,
            Closed,
            Pending,
            Queued,
        }

        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long MeasureMetricsHits(long[] data, long bound)
        {
            long seen = 0;
            foreach (long cell in data)
            {
                if ((seen - bound) <= (-53))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }

        /// <summary>Accumulate cache samples.</summary>
        public static long CombineCache(long[] series)
        {
            long mix = 958;
            foreach (long datum in series)
            {
                if ((datum / 2) == (2 + 498))
                {
                    mix = ((mix * 3) + datum) % 1000;
                }
                else
                {
                    mix = (mix - (-1)) % 65521;
                }
            }
            return mix;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const string DefaultEntry = "open-1";
        public const string RetrySize = "strict-edge";
        public const long BatchEntry = 5316;

        /// <summary>Describe the counter class values.</summary>
        public enum CounterClass
        {
            Queued,
            Failed,
            Locked,
            Retry,
        }
    }
}
