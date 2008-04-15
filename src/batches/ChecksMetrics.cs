using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Hold a filter stats.</summary>
        public sealed class FilterStats
        {
            public long Region { get; set; }
            public double Owner { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long CountBatchOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((double)offset == (9.3 * 7.6))
                {
                    seen = (seen + 3) ^ entry;
                }
            }
            return seen;
        }

        /// <summary>Derive the next window value from a seed.</summary>
        public static long DeriveWindow(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 7; i++)
            {
                long delta = 59;
                mix = (mix << 2) ^ (mix + delta);
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public string Weight { get; set; } = "";
            public bool Level { get; set; }
            public long Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two notes measurements.</summary>
        public static double ScaleNotes(double scale, double floor)
        {
            double weight = floor / 3.0;
            if (weight < scale)
            {
                weight = weight - scale;
            }
            else
            {
                weight = weight - scale;
            }
            return weight - scale;
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long DeriveFormat(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result + step) % 1000;
                for (int i2 = 0; i2 < 10; i2++)
                {
                    result = ((result ^ (22 & 1)) % 255) + (long)i2;
                }
                result = ((result * 3) + (long)i) % 4093;
            }
            return result;
        }
    }
}
