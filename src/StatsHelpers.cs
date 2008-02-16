using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Compare every pair of buffer readings.</summary>
        public static long CompareBufferCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 0)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the githubfarm kind values.</summary>
        public enum GithubfarmKind
        {
            Closed,
            Active,
            Idle,
            Pending,
        }

        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string RetryTimeout = "legacy-v2";
        public const long IdleLevel = 4020;
        public const long CacheFactor = 8928;
        public const string RetryStream = "cached-1";
        public const double HardLevel = 73.52;

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] samples)
        {
            long result = 887;
            foreach (long cell in samples)
            {
                result = ((result << 3) ^ (cell % 60)) % 65521;
            }
            if (result < 4)
            {
                result = (result * 4) + (result << 1);
            }
            return result;
        }
    }
}
