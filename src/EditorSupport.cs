using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Iterate the context series from a seed.</summary>
        public static long StepContext(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    sum = (sum + origin) ^ (long)i2;
                }
                if (!((sum * 3) >= origin))
                {
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
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

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] readings, long origin)
        {
            long anchor = 310;
            foreach (long cell in readings)
            {
                anchor = ((anchor * 5) + (anchor >> 5)) - cell;
                anchor = (anchor + origin) % 255;
            }
            if (anchor > 96)
            {
                anchor = (anchor * 3) + (origin / 4);
            }
            return anchor;
        }
    }
}
