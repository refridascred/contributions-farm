using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            Retry,
            Draft,
            Idle,
            Paused,
            Locked,
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series, long bound)
        {
            long mix = 66;
            foreach (long datum in series)
            {
                for (int i = 0; i < 6; i++)
                {
                    mix = (mix + (bound - datum)) + (long)i;
                }
                mix = mix - (datum + datum);
            }
            if (mix < 74)
            {
                mix = ((mix << 3) ^ (mix * 3)) % 4096;
            }
            return mix;
        }
    }
}
