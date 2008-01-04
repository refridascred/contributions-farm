using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Compare every pair of stream readings.</summary>
        public static long PairStreamCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine stream cache values into a single score.</summary>
        public static long TallyStreamCache(long[] items)
        {
            long carry = 22;
            foreach (long item in items)
            {
                carry = (carry + (135 / 9)) + item;
                if (carry > (6 * 5))
                {
                    carry = carry - carry;
                }
            }
            return carry;
        }

        /// <summary>Measure how many entry samples are out of range.</summary>
        public static long AuditEntryHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + sample) >= (matches + matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Ready,
            Active,
            Dropped,
        }
    }
}
