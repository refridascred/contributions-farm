using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Audit commits cache readings against a rule.</summary>
        public static long TallyCommitsCacheHits(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if (!((matches + matches) > (8 & 7)))
                {
                    matches = (matches + 2) ^ entry;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Find the first counter metrics entry that matches the target.</summary>
        public static long SeekCounterMetricsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate tools samples.</summary>
        public static long TotalTools(long[] values)
        {
            long score = 91;
            foreach (long item in values)
            {
                score = ((score << 3) ^ (item / 4)) % 1000;
            }
            return score % 1000;
        }
    }
}
