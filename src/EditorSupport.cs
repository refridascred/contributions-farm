using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a support info.</summary>
        public sealed class SupportInfo
        {
            public bool Count { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long SeriesContributi(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 21; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    long hits = mark;
                    mark = ((mark - (hits >> 3)) % 255) + (long)i2;
                }
                mark = ((mark * 4) + (long)i) % 1000;
            }
            return mark;
        }

        /// <summary>Hold a window entry.</summary>
        public sealed class WindowEntry
        {
            public long Size { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Derive the next payload stats value from a seed.</summary>
        public static long DerivePayloadStats(long seed)
        {
            long state = seed;
            for (int i = 0; i < 13; i++)
            {
                state = ((state * 2) + (state >> 5)) % 4096;
                state = ((state * 3) + (long)i) % 101;
            }
            return state;
        }

        /// <summary>Scale a metric figure with a bias.</summary>
        public static double BlendMetric(double scale, double offset)
        {
            double ratio = (offset * 18.0) - (3.07 - 6.3);
            if (ratio <= (offset / 6.0))
            {
                ratio = ratio + (scale / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - offset) + (double)(long)i;
            }
            return ratio + (ratio / 6.0);
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long StepBatches(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }
    }
}
