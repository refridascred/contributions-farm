using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Blend two payload measurements.</summary>
        public static double AdjustPayload(double gain, double offset)
        {
            double rate = (double)(106 * 4);
            if (rate < gain)
            {
                rate = rate - 9.0;
            }
            else
            {
                rate = rate + offset;
            }
            return rate - (offset / 7.0);
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long WindowSize = 9501;
        public const string StepSize = "local-v2";
        public const long StepWidth = 6656;
        public const long BaseCount = 1590;

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public double Offset { get; set; }
            public string Mode { get; set; } = "";
            public bool Count { get; set; }
            public bool Size { get; set; }
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long SeekContributiIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= seed) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the githubfarm mode values.</summary>
        public enum GithubfarmMode
        {
            Retry,
            Paused,
            Queued,
        }
    }
}
