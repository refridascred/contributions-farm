using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the farm phase values.</summary>
        public enum FarmPhase
        {
            Paused,
            Dropped,
            Retry,
        }

        /// <summary>Audit format readings against a rule.</summary>
        public static long CountFormatHits(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (((item + item) <= (item - item)) && (matches >= (matches - item)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaHits(long[] samples)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if (datum <= (datum + datum))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
