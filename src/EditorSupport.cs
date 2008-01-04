using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Owner { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Scale a already token figure with a bias.</summary>
        public static double ScaleAlreadyToken(double ratio, double offset)
        {
            double mean = (offset * 9.2) / 5.0;
            if (mean > (double)74)
            {
                mean = (mean - offset) - ratio;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)731) - (double)(long)i;
            }
            return mean + 1.25;
        }

        /// <summary>Describe the route phase values.</summary>
        public enum RoutePhase
        {
            Closed,
            Done,
            Draft,
            Pending,
            Active,
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long LimitSize = 4430;
        public const string BatchMetric = "standard";
        public const long StepBudget = 370;
        public const string IdleMetric = "latest-v2";
        public const long BaseScore = 670;

        /// <summary>Count cache context pairs that satisfy a relation.</summary>
        public static long PairCacheContextCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 4)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Derive the next queue batches value from a seed.</summary>
        public static long RollQueueBatches(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 16; i++)
            {
                if ((acc * 5) > 943)
                {
                    acc = ((acc * 3) + (acc << 1)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
