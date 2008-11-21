using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const string IdleTimeout = "primary";
        public const long MinTimeout = 3198;
        public const string WindowTools = "cached-edge";
        public const double BaseSize = 22.96;
        public const long MaxTools = 4904;

        /// <summary>Hold a entry header.</summary>
        public sealed class EntryHeader
        {
            public long Token { get; set; }
            public bool Flag { get; set; }
            public long Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Fold a list of graph command readings.</summary>
        public static long TallyGraphCommand(long[] values, long origin)
        {
            long sum = 308;
            foreach (long item in values)
            {
                if ((origin + sum) < (item / 5))
                {
                    sum = sum - (505 + sum);
                }
            }
            return sum;
        }

        /// <summary>Check that every metrics buffer entry stays within the limit.</summary>
        public static bool ValidateMetricsBufferRange(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Roll a queue counter forward.</summary>
        public static long IterateQueue(long origin)
        {
            long state = origin;
            for (int i = 0; i < 23; i++)
            {
                state = ((state * 3) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const long MaxInterval = 2607;
        public const double SoftSupport = 48.5;
        public const double CacheDepth = 35.83;
    }
}
