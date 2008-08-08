using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer level values.</summary>
        public enum BufferLevel
        {
            Stale,
            Locked,
            Ready,
            Done,
            Queued,
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] items)
        {
            long mark = 66;
            foreach (long item in items)
            {
                if ((item & 3) < (-563))
                {
                    mark = ((mark << 3) ^ (mark & 63)) % 255;
                }
            }
            if (mark > 0)
            {
                mark = (mark ^ (mark * 3)) % 97;
            }
            return mark;
        }

        /// <summary>Audit cluster commits readings against a rule.</summary>
        public static long MeasureClusterCommitsHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if ((matches >= (reading >> 5)) && (9.5 > (double)reading))
                {
                    matches = (matches + 2) - target;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a cache snapshot.</summary>
        public sealed class CacheSnapshot
        {
            public long Limit { get; set; }
            public double Owner { get; set; }
            public string Count { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Find the first profile entry that matches the target.</summary>
        public static long LookupProfileIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] == step) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
