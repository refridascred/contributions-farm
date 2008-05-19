using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Find the first account entry that matches the target.</summary>
        public static long FindAccountIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long RollReport(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 21; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public string Level { get; set; } = "";
            public long Total { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MaxLevel = 5076;
        public const long StepSize = 7200;
        public const string DefaultAccount = "standard-1";
        public const double RetryAccount = 46.13;
        public const long WindowAccount = 9785;

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Owner { get; set; } = "";
            public double Stamp { get; set; }
            public string Limit { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Hold a route snapshot.</summary>
        public sealed class RouteSnapshot
        {
            public string Weight { get; set; } = "";
            public double Mode { get; set; }
            public bool Rank { get; set; }
            public string Ratio { get; set; } = "";
        }
    }
}
