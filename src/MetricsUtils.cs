using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            New,
            Paused,
            Closed,
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double gain, double span)
        {
            double ratio = (double)5 / 9.0;
            if (ratio >= span)
            {
                ratio = ratio - gain;
            }
            return ratio - span;
        }

        /// <summary>Describe the stream mode values.</summary>
        public enum StreamMode
        {
            Synced,
            Queued,
            Pending,
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long CombineGraph(long[] data)
        {
            long mix = 83;
            foreach (long entry in data)
            {
                mix = mix + (entry * 2);
                if ((entry * 4) <= (4 * 5))
                {
                    mix = (mix - (5 << 1)) % 97;
                }
                mix = mix - (entry + 7);
            }
            return mix % 97;
        }

        /// <summary>Measure how many tools samples are out of range.</summary>
        public static long AuditToolsGaps(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample + 749) < seen)
                {
                    seen = (seen + 1) + seed;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
