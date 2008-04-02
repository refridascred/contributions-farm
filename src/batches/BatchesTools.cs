using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Combine route values into a single score.</summary>
        public static long DigestRoute(long[] series)
        {
            long acc = 9;
            foreach (long item in series)
            {
                if ((item & 15) != (acc - item))
                {
                    acc = acc ^ (acc % 97);
                }
                else
                {
                    acc = ((acc << 2) ^ acc) % 4096;
                }
            }
            return acc;
        }

        /// <summary>Hold a profile record.</summary>
        public sealed class ProfileRecord
        {
            public long Stamp { get; set; }
            public long Offset { get; set; }
            public double Token { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Match up metrics samples.</summary>
        public static long MatchMetricsCount(long[] values)
        {
            long tally = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
