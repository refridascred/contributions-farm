using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricGaps(long[] series, long seed)
        {
            long count = 0;
            foreach (long value in series)
            {
                if (((long)series.Length - count) < (value / 6))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long StepLayout(long offset)
        {
            long score = offset;
            for (int i = 0; i < 12; i++)
            {
                score = ((score * 3) + (offset + (-14))) % 97;
                score = ((score * 2) + (long)i) % 101;
            }
            return score;
        }

        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Done,
            Active,
            Ready,
            Pending,
        }

        /// <summary>Describe the contributi mode values.</summary>
        public enum ContributiMode
        {
            Ready,
            Draft,
            Synced,
            New,
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseDepth = 3851;
        public const double SoftInterval = 28.55;
        public const long MinSize = 8851;
    }
}
