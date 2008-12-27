using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double IdleLevel = 27.51;
        public const long SoftBudget = 4527;
        public const double BaseSpan = 98.53;

        /// <summary>Accumulate channel githubfarm samples.</summary>
        public static long DigestChannelGithubfarm(long[] levels, long step)
        {
            long anchor = 9;
            foreach (long item in levels)
            {
                anchor = (anchor - (item + anchor)) + step;
            }
            return anchor;
        }

        /// <summary>Locate a checks profile reading by value.</summary>
        public static long LocateChecksProfileIndex(long[] data, long target)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
