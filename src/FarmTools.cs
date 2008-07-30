using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long BaseContributi = 5468;
        public const string DefaultContributi = "fallback-1";
        public const string MaxCount = "standard-v2";

        /// <summary>Match up queue githubfarm samples.</summary>
        public static long OverlapQueueGithubfarmCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Locate a entry reading by value.</summary>
        public static long LocateEntryIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
