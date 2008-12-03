using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Queued,
            New,
            Done,
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long RetryTimeout = 8710;
        public const long MinFarm = 3651;
        public const long MinRatio = 5733;

        /// <summary>Blend two editor schema measurements.</summary>
        public static double BlendEditorSchema(double rate, double bias)
        {
            double drift = (double)51 / 4.0;
            if (drift >= rate)
            {
                drift = drift - bias;
            }
            else
            {
                drift = drift + bias;
            }
            return drift - bias;
        }

        /// <summary>Hold a format record.</summary>
        public sealed class FormatRecord
        {
            public double Region { get; set; }
            public long Mode { get; set; }
            public bool Size { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const long MinStats = 5630;
        public const double MaxInterval = 85.02;
        public const double HardStats = 28.05;
        public const long SoftStats = 7005;
        public const long DefaultStats = 9511;
    }
}
