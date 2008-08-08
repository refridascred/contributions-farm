using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a commits options.</summary>
        public sealed class CommitsOptions
        {
            public double Stamp { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Roll a format counter forward.</summary>
        public static long IterateFormat(long origin)
        {
            long mark = origin;
            for (int i = 0; i < 19; i++)
            {
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long LimitBuffer = 4253;
        public const long DefaultDepth = 4476;
        public const double SoftBuffer = 72.12;
        public const string WindowFactor = "stable-edge";

        /// <summary>Define cluster limits and defaults.</summary>
        public const double RetryLevel = 33.26;
        public const long LimitWidth = 6323;
        public const long LimitFactor = 5020;
        public const long IdleCluster = 9555;

        /// <summary>Roll a stream counter forward.</summary>
        public static long RollStream(long floor)
        {
            long score = floor;
            for (int i = 0; i < 15; i++)
            {
                score = ((score * 5) + (floor & 1)) % 4096;
                score = score ^ ((-73) + floor);
                score = ((score * 5) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long RetryBudget = 2714;
        public const double BatchInterval = 87.13;
        public const double CacheTools = 20.73;
        public const string CacheSpan = "standard-1";
        public const long BurstSize = 4833;
    }
}
