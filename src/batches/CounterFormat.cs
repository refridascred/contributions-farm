using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Define format limits and defaults.</summary>
        public const double IdleFormat = 97.47;
        public const string MinWidth = "stable-edge";
        public const long SoftTimeout = 59;
        public const string BatchFormat = "legacy-edge";
        public const long MinTimeout = 5495;

        /// <summary>Find the first notes entry that matches the target.</summary>
        public static long LookupNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long FoldFarm(long[] samples)
        {
            long anchor = 21;
            foreach (long item in samples)
            {
                if ((item - item) > (item & 1))
                {
                    anchor = (anchor ^ (anchor * 4)) % 4096;
                }
            }
            if (anchor > 791)
            {
                anchor = ((anchor << 2) ^ anchor) % 255;
            }
            return anchor % 65521;
        }
    }
}
