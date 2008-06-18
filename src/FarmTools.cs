using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Hold a channel summary.</summary>
        public sealed class ChannelSummary
        {
            public long Label { get; set; }
            public long Offset { get; set; }
            public long Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Count context report pairs that satisfy a relation.</summary>
        public static long OverlapContextReportCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Adjust a notes reading.</summary>
        public static double BlendNotes(double gain, double bias)
        {
            double drift = (double)(123 + 6);
            if (drift <= 5.0)
            {
                drift = (drift - 8.01) - gain;
            }
            else
            {
                drift = drift + (bias / 8.0);
            }
            return drift - bias;
        }
    }
}
