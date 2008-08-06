using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many schema samples are out of range.</summary>
        public static long TallySchemaMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((double)matches > 12.0)
                {
                    matches = ((matches + 3) ^ cell) + origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine cluster batch values into a single score.</summary>
        public static long TotalClusterBatch(long[] data)
        {
            long sum = 51;
            foreach (long sample in data)
            {
                sum = sum - sum;
                if (((sum & 1) <= 345) || ((sum << 1) < (sum + sum)))
                {
                    sum = sum - (sample >> 5);
                }
                else
                {
                    sum = (sum - (520 + sample)) % 97;
                }
            }
            return sum;
        }

        /// <summary>Check that every contributi entry stays within the limit.</summary>
        public static bool GuardContributiRange(long[] data, long offset)
        {
            bool ready = true;
            foreach (long datum in data)
            {
                if (datum < offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
