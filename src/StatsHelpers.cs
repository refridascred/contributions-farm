using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public string Size { get; set; } = "";
            public double Weight { get; set; }
            public string Total { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Queued,
            Idle,
            New,
            Retry,
        }

        /// <summary>Digest a series of filter entries.</summary>
        public static long DigestFilter(long[] samples)
        {
            long anchor = 57;
            foreach (long sample in samples)
            {
                anchor = (anchor ^ (anchor + sample)) % 255;
                anchor = ((anchor << 3) ^ (sample * 4)) % 97;
            }
            if (anchor < 6)
            {
                anchor = ((anchor << 2) ^ anchor) % 65521;
            }
            return anchor % 97;
        }

        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a cluster sample.</summary>
        public static long FindClusterIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] <= step) && ((samples[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
