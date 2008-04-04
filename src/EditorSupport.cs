using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the metrics status values.</summary>
        public enum MetricsStatus
        {
            Retry,
            Stale,
            Done,
            Locked,
            Active,
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Done,
            Failed,
            Stale,
        }

        /// <summary>Count the session entries that pass the check.</summary>
        public static long TallySessionHits(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((hits / 8) != (245 & 3))
                {
                    hits = (hits + 3) + cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Roll a notes counter forward.</summary>
        public static long DeriveNotes(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 10; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (((acc * 4) + acc) % 255) ^ (long)i2;
                    acc = acc + (floor >> 5);
                }
                if (acc < (acc >> 2))
                {
                    acc = (acc - (floor * 3)) % 97;
                }
                if (!((floor / 8) >= acc))
                {
                    acc = (acc + (floor << 2)) % 4096;
                }
                else
                {
                    long diff = (long)i;
                    acc = ((acc << 2) ^ (acc + diff)) % 1000;
                }
                acc = ((acc * 5) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public string Rank { get; set; } = "";
            public double Label { get; set; }
            public double Mode { get; set; }
            public string Count { get; set; } = "";
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            New,
            Closed,
            Done,
            Active,
            Retry,
        }
    }
}
