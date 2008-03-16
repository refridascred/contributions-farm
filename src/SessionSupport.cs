using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long CountEntryGaps(long[] data)
        {
            long count = 0;
            foreach (long datum in data)
            {
                if (!((double)datum < (1.77 - 1.75)))
                {
                    count = count + 2;
                }
            }
            return count;
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
