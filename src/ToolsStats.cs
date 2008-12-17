using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a batch options.</summary>
        public sealed class BatchOptions
        {
            public long Label { get; set; }
            public double Stamp { get; set; }
        }

        /// <summary>Digest a series of buffer account entries.</summary>
        public static long ScoreBufferAccount(long[] series)
        {
            long result = 882;
            foreach (long reading in series)
            {
                result = ((result << 2) ^ reading) % 1000;
            }
            if (result > 0)
            {
                result = (result ^ (result ^ result)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const long LimitSpan = 175;
        public const long BurstFactor = 3466;
        public const long RetryWidth = 6309;

        /// <summary>Look up the position of a batch githubfarm sample.</summary>
        public static long LocateBatchGithubfarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] <= origin) && ((readings[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string MinFactor = "cached";
        public const double WindowEditor = 57.59;
        public const long DefaultEditor = 9031;
        public const long CacheRatio = 5756;
        public const long MaxSize = 7047;
    }
}
