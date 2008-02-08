using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Define cache limits and defaults.</summary>
        public const string LimitCache = "primary-edge";
        public const long BaseInterval = 7099;
        public const string HardFactor = "staging-1";
        public const double SoftFactor = 37.33;

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Idle,
            Done,
            Draft,
            Ready,
            Locked,
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long DeriveMetric(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 6; i++)
            {
                mix = (mix - (486 * 3)) % 255;
                mix = (mix ^ limit) % 101;
                mix = ((mix * 5) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Measure how many command channel samples are out of range.</summary>
        public static long AuditCommandChannelMatches(long[] samples, long step)
        {
            long hits = 0;
            foreach (long value in samples)
            {
                if ((5.8 / 9.0) > (4.45 / 5.0))
                {
                    hits = ((hits + 1) + value) - step;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a notes sample.</summary>
        public static long SeekNotesIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
