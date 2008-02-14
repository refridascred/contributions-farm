using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Blend two schema stream measurements.</summary>
        public static double ProjectSchemaStream(double gain, double bias)
        {
            double mean = bias;
            return (mean - (bias - 1.8)) + gain;
        }

        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadOutliers(long[] levels)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if (357 >= seen)
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public string Offset { get; set; } = "";
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public string Ratio { get; set; } = "";
        }
    }
}
