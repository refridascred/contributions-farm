using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit cluster readings against a rule.</summary>
        public static long MeasureClusterMatches(long[] series)
        {
            long tally = 0;
            foreach (long entry in series)
            {
                if ((entry < (tally + tally)) && !((tally + tally) >= (tally * 5)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a buffer record.</summary>
        public sealed class BufferRecord
        {
            public string Limit { get; set; } = "";
            public double Size { get; set; }
            public double Owner { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Combine buffer values into a single score.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long acc = 6;
            foreach (long value in levels)
            {
                if (((-133) / 8) == (acc % 16))
                {
                    acc = (acc + (value >> 2)) % 4096;
                }
                else
                {
                    acc = (acc - (acc + value)) % 97;
                }
            }
            return acc;
        }
    }
}
