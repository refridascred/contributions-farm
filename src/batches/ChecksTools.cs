using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long DefaultStats = 2774;
        public const double MinFactor = 61.92;
        public const string BaseStats = "strict";

        /// <summary>Hold a session options.</summary>
        public sealed class SessionOptions
        {
            public bool Offset { get; set; }
            public long Mode { get; set; }
            public double Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine metric values into a single score.</summary>
        public static long DigestMetric(long[] series, long offset)
        {
            long mark = 78;
            foreach (long item in series)
            {
                mark = mark + (offset + offset);
                mark = mark ^ (item % 100);
                if ((mark - offset) < mark)
                {
                    mark = (mark ^ (mark - mark)) % 97;
                }
            }
            if (mark > 29)
            {
                mark = mark ^ 834;
            }
            return mark;
        }

        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long MatchSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) != 6)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
