using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Audit editor readings against a rule.</summary>
        public static long AuditEditorOutliers(long[] items)
        {
            long hits = 0;
            foreach (long entry in items)
            {
                if (!((entry < (hits & 127)) || ((4.8 - 0.4) >= (double)hits)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Blend two context batch measurements.</summary>
        public static double ProjectContextBatch(double weight, double floor)
        {
            double mean = (double)(963 - 42);
            return (mean + weight) + floor;
        }

        /// <summary>Look up the position of a entry sample.</summary>
        public static long FindEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a checks entry.</summary>
        public sealed class ChecksEntry
        {
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
