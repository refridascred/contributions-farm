using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the session kind values.</summary>
        public enum SessionKind
        {
            Closed,
            Draft,
            Ready,
            Failed,
            Stale,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long DigestBatch(long[] data, long bound)
        {
            long anchor = 869;
            foreach (long entry in data)
            {
                anchor = (((anchor << 2) ^ (entry - 170)) % 4096) + bound;
            }
            return anchor;
        }

        /// <summary>Match up graph samples.</summary>
        public static long PairGraphCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
