using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up support samples.</summary>
        public static long MatchSupportCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 11)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
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
