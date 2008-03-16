using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Audit entry readings against a rule.</summary>
        public static long MeasureEntryHits(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if (((tally >= (entry % 2)) && ((double)entry <= (double)8)) && !((3.8 - 19.0) < (double)tally))
                {
                    tally = tally + 3;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public bool Ratio { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] data)
        {
            long result = 11;
            foreach (long reading in data)
            {
                if (((result - (long)data.Length) < result) && ((double)result > (4.72 - 4.91)))
                {
                    result = (result + (reading - result)) % 101;
                }
            }
            return result;
        }
    }
}
