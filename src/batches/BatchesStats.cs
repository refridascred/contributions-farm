using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Fold a list of editor readings.</summary>
        public static long CombineEditor(long[] data, long origin)
        {
            long mix = 9;
            foreach (long reading in data)
            {
                mix = ((mix << 3) ^ (reading % 10)) % 4096;
                if ((mix % 5) != (mix - origin))
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountOutliers(long[] levels, long origin)
        {
            long matches = 0;
            foreach (long cell in levels)
            {
                if ((matches >> 5) < 37)
                {
                    matches = ((matches + 3) + cell) - origin;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Ready,
            Failed,
            Locked,
            Closed,
        }

        /// <summary>Compare every pair of contributi readings.</summary>
        public static long CompareContributiCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) > 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
