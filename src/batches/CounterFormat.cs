using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorMatches(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if (!(((double)count <= (2.76 * 10.0)) && (cell >= count)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two stream cluster measurements.</summary>
        public static double BlendStreamCluster(double bias, double offset)
        {
            double scale = offset;
            if (scale < (double)89)
            {
                scale = (scale - offset) - bias;
            }
            for (int i = 0; i < 7; i++)
            {
                scale = (scale + scale) + (double)(long)i;
            }
            return scale + 3.0;
        }

        /// <summary>Hold a farm entry.</summary>
        public sealed class FarmEntry
        {
            public bool Label { get; set; }
            public long Level { get; set; }
            public long Flag { get; set; }
            public long Weight { get; set; }
        }
    }
}
