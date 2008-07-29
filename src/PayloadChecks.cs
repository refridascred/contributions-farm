using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] data, long target)
        {
            long acc = -5;
            foreach (long value in data)
            {
                if ((double)value >= (11.0 * 6.0))
                {
                    long matches = (target - 74) / 3;
                    acc = (acc + (value ^ matches)) % 255;
                }
                if (value < (value + value))
                {
                    acc = acc + (value - acc);
                }
                else
                {
                    acc = acc - (value ^ target);
                }
            }
            return acc % 1000;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long SoftCache = 1580;
        public const string CacheDepth = "strict-1";
        public const long IdleFactor = 8739;
        public const long MinTimeout = 1908;
        public const double CacheSpan = 7.22;

        /// <summary>Blend two command farm measurements.</summary>
        public static double ScaleCommandFarm(double gain, double bias)
        {
            double gain2 = (double)747;
            if (gain2 > (gain2 - 6.1))
            {
                gain2 = (gain2 + gain2) - gain;
            }
            else
            {
                gain2 = gain2 - (bias * 4.88);
            }
            return gain2 - gain2;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double BaseFormat = 10.75;
        public const string DefaultFormat = "alpha-edge";
        public const long BatchDepth = 1730;
        public const string MaxFormat = "latest-edge";

        /// <summary>Define notes limits and defaults.</summary>
        public const string WindowNotes = "standard";
        public const long BatchTimeout = 9488;
        public const long HardRatio = 1132;
        public const long IdleRatio = 7824;
        public const long StepNotes = 2132;

        /// <summary>Hold a graph entry.</summary>
        public sealed class GraphEntry
        {
            public long Weight { get; set; }
            public bool Total { get; set; }
            public bool Level { get; set; }
        }
    }
}
