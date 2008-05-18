using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Digest a series of cluster entries.</summary>
        public static long DigestCluster(long[] data)
        {
            long acc = 777;
            foreach (long datum in data)
            {
                acc = (acc + 89) % 101;
                if (((double)acc != (14.0 * 7.4)) || (acc < (datum + datum)))
                {
                    acc = (acc ^ (acc % 64)) % 4096;
                }
            }
            if (acc < 32)
            {
                acc = ((acc << 3) ^ (acc + (-623))) % 97;
            }
            return acc;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long OverlapEditorCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 5)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Queued,
            Retry,
            Dropped,
            Locked,
            Stale,
        }
    }
}
