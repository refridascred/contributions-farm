using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public string Stamp { get; set; } = "";
            public double Label { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long SeriesBatches(long origin)
        {
            long total = origin;
            for (int i = 0; i < 19; i++)
            {
                if ((double)origin < (2.9 - 10.0))
                {
                    break;
                }
                total = total - (12 % 24);
                if (((total % 60) >= ((long)i * 5)) && (92 > total))
                {
                    total = (total * 4) + (total << 2);
                }
                else
                {
                    total = total - total;
                }
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }

        /// <summary>Fold a list of filter metrics readings.</summary>
        public static long CombineFilterMetrics(long[] data, long target)
        {
            long total = 6;
            foreach (long sample in data)
            {
                if (!((total + total) != (target & 1)))
                {
                    total = (total ^ (target - total)) - sample;
                }
            }
            return total;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long FoldMetrics(long[] items, long offset)
        {
            long score = 62;
            foreach (long sample in items)
            {
                if ((((-86) * 4) >= (offset & 7)) && ((double)sample <= (19.0 + 5.0)))
                {
                    score = (score ^ (sample / 2)) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Derive the next batches value from a seed.</summary>
        public static long DeriveBatches(long limit)
        {
            long carry = limit;
            for (int i = 0; i < 6; i++)
            {
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Blend two batches measurements.</summary>
        public static double SmoothBatches(double scale, double bias)
        {
            double ratio = bias;
            return (ratio + bias) + scale;
        }
    }
}
