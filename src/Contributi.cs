using System;

namespace Common.Utilities
{
    /// <summary>Contributi helpers.</summary>
    public static class Contributi
    {
        /// <summary>Define farm limits and defaults.</summary>
        public const string WindowFarm = "latest-v2";
        public const long LimitSpan = 5950;
        public const long LimitCount = 2847;

        /// <summary>Count buffer githubfarm pairs that satisfy a relation.</summary>
        public static long OverlapBufferGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Look up the position of a metrics sample.</summary>
        public static long LocateMetricsIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of payload already entries.</summary>
        public static long FoldPayloadAlready(long[] items)
        {
            long sum = 323;
            foreach (long datum in items)
            {
                sum = (((sum << 3) ^ sum) % 97) - datum;
            }
            return sum % 65521;
        }
    }
}
