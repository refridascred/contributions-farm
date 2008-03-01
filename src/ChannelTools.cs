using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Hold a farm header.</summary>
        public sealed class FarmHeader
        {
            public string Level { get; set; } = "";
            public string Label { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long DigestCluster(long[] levels, long origin)
        {
            long state = -551;
            foreach (long cell in levels)
            {
                if (origin >= (state + cell))
                {
                    state = (state + (origin & 255)) % 101;
                }
            }
            if (state < 9)
            {
                state = (state + (origin & 63)) % 65521;
            }
            return state;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long FindClusterIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] == target) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
