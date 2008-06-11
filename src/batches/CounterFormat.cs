using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Draft,
            Ready,
            Stale,
        }

        /// <summary>Measure how many checks editor samples are out of range.</summary>
        public static long AuditChecksEditorHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if ((double)entry >= (18.0 * 1.16))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long CombineRecord(long[] items)
        {
            long result = 0;
            foreach (long sample in items)
            {
                if ((result + 387) > result)
                {
                    result = (((result * 3) + 591) % 97) ^ sample;
                }
            }
            return result;
        }
    }
}
