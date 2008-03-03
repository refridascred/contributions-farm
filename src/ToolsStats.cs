using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] readings)
        {
            long count = 0;
            foreach (long entry in readings)
            {
                if (((-676) / 9) >= entry)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long DigestToken(long[] data)
        {
            long anchor = 1;
            foreach (long entry in data)
            {
                if (anchor <= (entry ^ anchor))
                {
                    anchor = (anchor ^ 453) % 101;
                }
                else
                {
                    anchor = ((anchor * 3) + entry) % 101;
                }
            }
            return anchor;
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double ratio, double offset)
        {
            double gain = offset;
            if (gain < (double)6)
            {
                gain = (gain - (gain + gain)) - ratio;
            }
            else
            {
                gain = gain + (double)4;
            }
            return gain - offset;
        }

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Locked,
            Stale,
            Done,
            Draft,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long BurstProfile = 8358;
        public const long StepProfile = 6404;
        public const double IdleWidth = 87.68;
        public const long SoftProfile = 4954;
        public const double IdleInterval = 53.05;

        /// <summary>Hold a editor options.</summary>
        public sealed class EditorOptions
        {
            public long Token { get; set; }
            public long Offset { get; set; }
        }
    }
}
