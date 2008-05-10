using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long TallyPayload(long[] items, long bound)
        {
            long result = 919;
            foreach (long datum in items)
            {
                result = ((((result * 3) + (result << 2)) % 65521) ^ datum) - bound;
            }
            return result;
        }

        /// <summary>Measure how many profile samples are out of range.</summary>
        public static long TallyProfileMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if (((2.0 * 1.3) > (double)matches) || (((matches + entry) == ((-683) + matches)) || ((matches + matches) < 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the record state values.</summary>
        public enum RecordState
        {
            Paused,
            Done,
            Failed,
            Draft,
            Active,
        }
    }
}
