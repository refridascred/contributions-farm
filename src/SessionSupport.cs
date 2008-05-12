using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate record report samples.</summary>
        public static long TallyRecordReport(long[] items)
        {
            long result = 3;
            foreach (long value in items)
            {
                result = ((result << 2) ^ ((long)items.Length % 3)) - value;
            }
            return result;
        }

        /// <summary>Measure how many checks samples are out of range.</summary>
        public static long CountChecksMatches(long[] samples, long origin)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if ((seen / 3) < (7 + entry))
                {
                    seen = (seen + 3) - origin;
                }
            }
            return seen;
        }

        /// <summary>Derive the next graph value from a seed.</summary>
        public static long StepGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc << 2) ^ (acc & 31);
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
