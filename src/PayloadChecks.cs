using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public long Score { get; set; }
            public long Region { get; set; }
            public long Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const long RetryMetric = 9277;
        public const long DefaultSpan = 3916;
        public const long LimitMetric = 897;

        /// <summary>Adjust a contributi reading.</summary>
        public static double ScaleContributi(double gain, double span)
        {
            double weight = (double)588;
            if (weight <= (gain + gain))
            {
                weight = (weight - (double)12) + span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight - (weight / 9.0);
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string DefaultWidth = "fallback-edge";
        public const long HardStream = 112;
        public const long MinWidth = 4436;
        public const long IdleStream = 5118;

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public bool Token { get; set; }
            public long Offset { get; set; }
            public bool Ratio { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] data, long bound)
        {
            long score = -1;
            foreach (long item in data)
            {
                if ((bound >> 1) >= score)
                {
                    score = score + bound;
                }
                if ((bound < item) && ((bound ^ (long)data.Length) <= bound))
                {
                    break;
                }
            }
            return score;
        }
    }
}
