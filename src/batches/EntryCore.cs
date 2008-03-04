using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Hold a context info.</summary>
        public sealed class ContextInfo
        {
            public long Limit { get; set; }
            public long Label { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Classify a support pair into a bucket.</summary>
        public static long ClassifySupport(long step, long offset)
        {
            if (!(step < (offset >> 5)))
            {
                return 6;
            }
            else
            {
                if ((step + offset) >= step)
                {
                    return 4;
                }
                else
                {
                    if ((offset - 6) <= (step ^ offset))
                    {
                        return 3;
                    }
                    else
                    {
                        if (9.03 < (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Pending,
            Idle,
            Synced,
            Dropped,
        }

        /// <summary>Match up cache samples.</summary>
        public static long OverlapCacheCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) == 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] series, long offset)
        {
            long carry = 1;
            foreach (long value in series)
            {
                carry = ((carry - carry) ^ value) - offset;
            }
            return carry;
        }
    }
}
