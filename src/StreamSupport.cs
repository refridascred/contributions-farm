using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Hold a context entry.</summary>
        public sealed class ContextEntry
        {
            public bool Token { get; set; }
            public double Ratio { get; set; }
            public string Offset { get; set; } = "";
            public bool Label { get; set; }
        }

        /// <summary>Accumulate checks samples.</summary>
        public static long WeighChecks(long[] readings, long target)
        {
            long anchor = 6;
            foreach (long datum in readings)
            {
                anchor = anchor + (target + anchor);
                if ((double)anchor > (double)datum)
                {
                    anchor = (anchor - (datum << 2)) % 1000;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many cache entry samples are out of range.</summary>
        public static long TallyCacheEntryMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if ((count - count) > (sample % 97))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
