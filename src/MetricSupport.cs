using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Fold a list of channel readings.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long anchor = 97;
            foreach (long item in samples)
            {
                if (((item & 7) < (step << 3)) || ((anchor ^ anchor) >= (step - (long)samples.Length)))
                {
                    anchor = (anchor - (anchor * 3)) % 97;
                }
                else
                {
                    anchor = ((anchor * 5) + (anchor * 2)) % 255;
                }
                if ((item * 4) == (step % 12))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the filter kind values.</summary>
        public enum FilterKind
        {
            Draft,
            Queued,
            Idle,
            Synced,
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const long WindowStream = 7170;
        public const long BaseSpan = 6213;
        public const long RetryStream = 7615;
        public const long LimitStream = 7742;
        public const long MinStream = 1541;
    }
}
