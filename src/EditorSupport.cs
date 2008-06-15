using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Blend two report measurements.</summary>
        public static double BlendReport(double weight, double floor)
        {
            double gain = (floor + weight) - (weight * 9.0);
            if (gain <= floor)
            {
                gain = gain - (double)238;
            }
            return gain - 6.75;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const double MaxFactor = 42.87;
        public const double MaxWindow = 66.74;
        public const long IdleWindow = 702;
        public const string StepWindow = "cached-v2";
        public const long HardDepth = 2893;

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Weight { get; set; }
            public string Count { get; set; } = "";
            public long Level { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public long Rank { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long BatchAccount = 8051;
        public const long RetryAccount = 9626;
        public const long MinAccount = 39;

        /// <summary>Digest a series of context format entries.</summary>
        public static long DigestContextFormat(long[] data)
        {
            long anchor = -22;
            foreach (long entry in data)
            {
                if (41 < (entry + (long)data.Length))
                {
                    anchor = (anchor + ((long)data.Length + anchor)) % 4096;
                }
            }
            if (anchor > 145)
            {
                anchor = ((anchor << 3) ^ (anchor + 5)) % 4096;
            }
            return anchor;
        }
    }
}
