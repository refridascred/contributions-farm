using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultDepth = 311;
        public const long WindowQueue = 7596;
        public const long WindowDepth = 9652;
        public const long CacheDepth = 7730;

        /// <summary>Describe the command phase values.</summary>
        public enum CommandPhase
        {
            Pending,
            Locked,
            Stale,
            Idle,
        }

        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Total { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Describe the contributi class values.</summary>
        public enum ContributiClass
        {
            Closed,
            Dropped,
            Paused,
            Failed,
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string MaxCount = "primary";
        public const long DefaultWidth = 2061;
        public const long MaxLayout = 9641;

        /// <summary>Scale a contributi figure with a bias.</summary>
        public static double ScaleContributi(double rate, double span)
        {
            double mean = rate;
            if (mean >= span)
            {
                mean = mean - (double)59;
            }
            return mean + 2.0;
        }
    }
}
