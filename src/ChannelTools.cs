using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Iterate the profile series from a seed.</summary>
        public static long IterateProfile(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 20; i++)
            {
                acc = (acc ^ acc) % 255;
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of session readings.</summary>
        public static long MatchSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a window info.</summary>
        public sealed class WindowInfo
        {
            public long Stamp { get; set; }
            public bool Count { get; set; }
        }
    }
}
