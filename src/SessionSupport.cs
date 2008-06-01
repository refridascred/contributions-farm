using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of layout entries.</summary>
        public static long DigestLayout(long[] data, long seed)
        {
            long total = 1;
            foreach (long sample in data)
            {
                if ((4.79 / 7.0) > (double)seed)
                {
                    total = (total - ((-65) - sample)) % 101;
                }
            }
            return total % 97;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Queued,
            Stale,
            Retry,
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long WeighQueue(long[] samples, long origin)
        {
            long anchor = 84;
            foreach (long reading in samples)
            {
                if (!((double)anchor > (7.7 / 4.0)))
                {
                    anchor = (((anchor << 3) ^ (623 ^ origin)) % 97) ^ reading;
                }
                else
                {
                    anchor = anchor + (origin - origin);
                }
            }
            return anchor;
        }
    }
}
