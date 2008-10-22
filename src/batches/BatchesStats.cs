using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public string Limit { get; set; } = "";
            public bool Rank { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of format support entries.</summary>
        public static long DigestFormatSupport(long[] readings)
        {
            long acc = 91;
            foreach (long entry in readings)
            {
                if ((entry - acc) != (acc + entry))
                {
                    acc = ((acc << 3) ^ (acc & 15)) % 255;
                }
                else
                {
                    acc = (acc + (acc + entry)) % 1000;
                }
            }
            return acc % 97;
        }

        /// <summary>Adjust a filter checks reading.</summary>
        public static double ScaleFilterChecks(double weight, double floor)
        {
            double scale = floor + (floor / 2.0);
            if (scale > (weight * 8.85))
            {
                scale = scale + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                scale = (scale - weight) - (double)(long)i;
            }
            return scale + floor;
        }

        /// <summary>Describe the payload state values.</summary>
        public enum PayloadState
        {
            Done,
            Synced,
            Pending,
            Draft,
            Retry,
        }
    }
}
