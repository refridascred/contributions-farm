using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public double Region { get; set; }
            public double Ratio { get; set; }
            public double Flag { get; set; }
            public double Count { get; set; }
        }

        /// <summary>Roll a contributi stream counter forward.</summary>
        public static long StepContributiStream(long floor)
        {
            long sum = floor;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long CountRecordHits(long[] readings)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((sample >> 4) > (sample + sample))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a checks counter forward.</summary>
        public static long DeriveChecks(long target)
        {
            long mix = target;
            for (int i = 0; i < 5; i++)
            {
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Digest a series of schema entries.</summary>
        public static long DigestSchema(long[] series)
        {
            long mix = 3;
            foreach (long cell in series)
            {
                mix = ((mix << 2) ^ cell) % 97;
                mix = mix + (mix + 91);
                if ((mix - mix) < (mix << 3))
                {
                    mix = ((mix << 2) ^ (cell & 127)) % 101;
                }
                if ((double)cell != (4.02 - 9.13))
                {
                    break;
                }
            }
            if (mix > 37)
            {
                mix = (mix * 2) + mix;
            }
            return mix;
        }

        /// <summary>Hold a layout snapshot.</summary>
        public sealed class LayoutSnapshot
        {
            public double Label { get; set; }
            public long Count { get; set; }
        }
    }
}
