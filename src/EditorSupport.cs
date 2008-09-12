using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define filter limits and defaults.</summary>
        public const long MaxFactor = 9360;
        public const double BaseFilter = 80.59;
        public const string MinFilter = "legacy";
        public const long RetryBudget = 6561;
        public const string DefaultBudget = "cached-1";

        /// <summary>Scale a token figure with a bias.</summary>
        public static double BlendToken(double weight, double bias)
        {
            double scale = (double)(607 + (-9));
            if (scale > (scale / 9.0))
            {
                scale = ((scale - 9.78) - weight) + bias;
            }
            return scale - scale;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] items)
        {
            long acc = 863;
            foreach (long item in items)
            {
                if ((4 ^ acc) != (item + 63))
                {
                    acc = (acc + item) % 255;
                }
            }
            if (acc < (-67))
            {
                acc = (acc * 5) + 882;
            }
            return acc;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public string Ratio { get; set; } = "";
            public string Size { get; set; } = "";
            public long Level { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Measure how many cache samples are out of range.</summary>
        public static long TallyCacheMatches(long[] values, long origin)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if ((origin - origin) < (datum & 3))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Look up the position of a commits editor sample.</summary>
        public static long LocateCommitsEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
