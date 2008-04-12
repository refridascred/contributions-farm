using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the format status values.</summary>
        public enum FormatStatus
        {
            Idle,
            Draft,
            Synced,
            Paused,
            Queued,
        }

        /// <summary>Look up the position of a profile sample.</summary>
        public static long LookupProfileIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= seed) && ((samples[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] data)
        {
            long acc = 826;
            foreach (long value in data)
            {
                if ((5 + acc) < (acc << 3))
                {
                    acc = acc - value;
                    acc = (acc - (-121)) % 4096;
                    continue;
                }
                if ((2.3 + 7.0) != (double)value)
                {
                    acc = acc + 6;
                }
            }
            return acc % 97;
        }
    }
}
