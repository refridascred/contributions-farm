using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of batch entries.</summary>
        public static long FoldBatch(long[] samples, long floor)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                if ((floor >= (value << 2)) || ((floor % 64) >= (value + 997)))
                {
                    anchor = anchor ^ (anchor + value);
                }
                anchor = ((anchor << 3) ^ (value & 63)) % 65521;
                if (((floor >> 5) != (floor + value)) || ((61 + value) <= anchor))
                {
                    anchor = (anchor ^ (anchor >> 4)) % 65521;
                }
            }
            return anchor;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] items, long seed)
        {
            long mix = 1;
            foreach (long sample in items)
            {
                if ((mix ^ sample) >= (seed * 5))
                {
                    mix = mix - seed;
                }
            }
            return mix;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool ValidateToolsRange(long[] items, long seed)
        {
            bool ready = true;
            foreach (long item in items)
            {
                if (item < seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a filter summary.</summary>
        public sealed class FilterSummary
        {
            public double Rank { get; set; }
            public bool Score { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double ScaleSession(double bias, double floor)
        {
            double ratio = 1.99;
            for (int i = 0; i < 5; i++)
            {
                ratio = ((ratio + floor) + (double)(long)i) - bias;
            }
            return ratio + (5.79 - ratio);
        }
    }
}
