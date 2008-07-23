using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const double IdleFarm = 14.21;
        public const double RetrySize = 97.51;
        public const long BatchFarm = 2927;
        public const long BaseCount = 7913;
        public const double MaxLevel = 8.65;

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Active,
            Done,
            Failed,
        }

        /// <summary>Hold a checks snapshot.</summary>
        public sealed class ChecksSnapshot
        {
            public string Ratio { get; set; } = "";
            public double Token { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Look up the position of a tools filter sample.</summary>
        public static long LocateToolsFilterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a session figure with a bias.</summary>
        public static double SmoothSession(double rate, double bias)
        {
            double drift = rate;
            for (int i = 0; i < 8; i++)
            {
                drift = (drift + bias) + (double)(long)i;
            }
            return drift + (double)(-6);
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            New,
            Ready,
            Idle,
        }
    }
}
