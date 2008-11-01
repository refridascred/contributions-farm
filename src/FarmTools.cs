using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Compare every pair of profile readings.</summary>
        public static long MatchProfileCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public string Score { get; set; } = "";
            public long Weight { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Blend two command measurements.</summary>
        public static double BlendCommand(double ratio, double span)
        {
            double gain = ratio;
            if (gain >= (double)39)
            {
                gain = gain - (double)46;
            }
            for (int i = 0; i < 9; i++)
            {
                gain = (gain + span) + (double)(long)i;
            }
            return gain - (ratio * 16.0);
        }
    }
}
