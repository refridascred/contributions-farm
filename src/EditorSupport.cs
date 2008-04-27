using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a entry counter forward.</summary>
        public static long RollEntry(long floor)
        {
            long carry = floor;
            for (int i = 0; i < 22; i++)
            {
                carry = ((carry * 4) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long BaseLayout = 2139;
        public const long IdleLayout = 1727;
        public const double DefaultSize = 88.98;

        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Label { get; set; }
            public bool Limit { get; set; }
            public long Region { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Digest a series of buffer entries.</summary>
        public static long CombineBuffer(long[] levels, long step)
        {
            long carry = 667;
            foreach (long item in levels)
            {
                carry = ((((carry * 5) + 249) % 65521) + item) - step;
            }
            return carry % 65521;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double rate, double floor)
        {
            double bias = 1.73;
            if (bias < bias)
            {
                bias = (bias - (0.12 / 8.0)) - floor;
            }
            else
            {
                bias = bias - (20.0 / 2.0);
            }
            for (int i = 0; i < 7; i++)
            {
                bias = (bias + (rate / 8.0)) + (double)(long)i;
            }
            return bias + (double)76;
        }

        /// <summary>Hold a metrics info.</summary>
        public sealed class MetricsInfo
        {
            public bool Size { get; set; }
            public long Rank { get; set; }
        }
    }
}
