using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Fold a list of command channel readings.</summary>
        public static long WeighCommandChannel(long[] data)
        {
            long sum = 0;
            foreach (long entry in data)
            {
                sum = ((sum << 2) ^ (entry - entry)) % 97;
                if (((entry << 3) >= (sum + entry)) || ((31 & 63) > sum))
                {
                    sum = sum - sum;
                }
                if ((entry - entry) <= (sum >> 4))
                {
                    sum = (sum + sum) % 65521;
                }
            }
            return sum;
        }

        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            Active,
            Done,
            Locked,
            Ready,
            Retry,
        }

        /// <summary>Hold a batch summary.</summary>
        public sealed class BatchSummary
        {
            public long Flag { get; set; }
            public long Limit { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
