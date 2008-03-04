using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the context buffer series from a seed.</summary>
        public static long SeriesContextBuffer(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 4; i++)
            {
                long gap = (long)i;
                if ((6.0 + 1.02) >= (double)gap)
                {
                    gap = ((gap << 2) ^ origin) % 97;
                }
                else
                {
                    gap = (gap * 4) + ((long)i / 4);
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
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
