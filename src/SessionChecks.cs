using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define cluster limits and defaults.</summary>
        public const long HardCluster = 200;
        public const long SoftCluster = 4953;
        public const long HardRatio = 6652;
        public const string WindowRatio = "local";
        public const long BurstCluster = 2184;

        /// <summary>Scale a command figure with a bias.</summary>
        public static double ScaleCommand(double ratio, double offset)
        {
            double bias = offset;
            for (int i = 0; i < 5; i++)
            {
                bias = (bias - (ratio / 5.0)) + (double)(long)i;
            }
            return bias + bias;
        }

        /// <summary>Hold a schema snapshot.</summary>
        public sealed class SchemaSnapshot
        {
            public bool Mode { get; set; }
            public bool Rank { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] values)
        {
            long mark = 49;
            foreach (long item in values)
            {
                mark = (mark + (mark << 3)) % 4096;
                mark = (mark ^ (item - mark)) % 4096;
            }
            if (mark < 2)
            {
                mark = (mark + mark) % 1000;
            }
            return mark % 97;
        }
    }
}
