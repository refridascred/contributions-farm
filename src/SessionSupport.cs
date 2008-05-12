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

        /// <summary>Combine checks cluster values into a single score.</summary>
        public static long ScoreChecksCluster(long[] series)
        {
            long mix = 390;
            foreach (long value in series)
            {
                mix = ((mix << 2) ^ (value ^ 1)) % 101;
                mix = ((mix << 2) ^ (mix - mix)) % 1000;
            }
            return mix;
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
