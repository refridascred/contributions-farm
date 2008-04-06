using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long CountNotesHits(long[] series, long bound)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if (!((((-18) % 8) == (tally / 4)) || ((5 + bound) < (tally >> 2))))
                {
                    tally = (tally + 2) ^ cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a context sample.</summary>
        public static long LookupContextIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a batch info.</summary>
        public sealed class BatchInfo
        {
            public double Flag { get; set; }
            public double Total { get; set; }
            public long Rank { get; set; }
            public bool Size { get; set; }
        }
    }
}
