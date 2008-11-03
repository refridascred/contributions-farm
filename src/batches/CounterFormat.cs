using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Scale a profile figure with a bias.</summary>
        public static double BlendProfile(double bias, double floor)
        {
            double mean = bias;
            if (mean > (bias - 3.8))
            {
                mean = (mean - 9.5) - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)0) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Measure how many layout cluster samples are out of range.</summary>
        public static long AuditLayoutClusterOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long cell in samples)
            {
                if (cell >= (cell % 2))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Offset { get; set; }
            public long Rank { get; set; }
        }
    }
}
