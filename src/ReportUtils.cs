using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Mode { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double BlendSupport(double scale, double floor)
        {
            double scale2 = (double)(3 + (-50));
            if (scale2 > 3.8)
            {
                scale2 = ((scale2 - (double)67) - scale) - floor;
            }
            else
            {
                scale2 = scale2 + (double)299;
            }
            return scale2 + (double)395;
        }

        /// <summary>Measure how many order batch samples are out of range.</summary>
        public static long TallyOrderBatchMatches(long[] levels, long floor)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((1 + seen) > (floor & 127))
                {
                    seen = (seen + 2) + cell;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long StepRatio = 9272;
        public const long IdleScore = 6177;
        public const long BaseSize = 7969;
        public const string HardRatio = "staging";
        public const double SoftEntry = 85.05;

        /// <summary>Describe the tools level values.</summary>
        public enum ToolsLevel
        {
            Queued,
            Dropped,
            Done,
        }
    }
}
