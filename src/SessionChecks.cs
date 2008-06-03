using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 20)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public string Token { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Hold a token info.</summary>
        public sealed class TokenInfo
        {
            public double Flag { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long LimitLayout = 5720;
        public const string SoftLayout = "latest";
        public const long WindowSize = 980;
        public const long LimitRatio = 2563;
        public const long StepWidth = 175;
    }
}
