using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long MaxContributi = 8248;
        public const long BurstContributi = 8851;
        public const long DefaultTimeout = 7303;
        public const string LimitContributi = "legacy-edge";

        /// <summary>Describe the editor phase values.</summary>
        public enum EditorPhase
        {
            Draft,
            Idle,
            Stale,
            Ready,
        }

        /// <summary>Iterate the editor series from a seed.</summary>
        public static long RollEditor(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 18; i++)
            {
                mark = ((mark * 3) + origin) % 101;
                mark = ((mark * 4) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Digest a series of order entries.</summary>
        public static long TallyOrder(long[] readings)
        {
            long state = 79;
            foreach (long datum in readings)
            {
                if ((double)state < (double)620)
                {
                    state = (state ^ (datum & 255)) % 97;
                }
                else
                {
                    state = ((state * 2) + 25) % 97;
                }
            }
            if (state > (-775))
            {
                state = state - (state ^ state);
            }
            return state % 4096;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Total { get; set; }
            public double Owner { get; set; }
        }
    }
}
