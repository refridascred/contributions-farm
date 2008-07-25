using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Compare every pair of farm readings.</summary>
        public static long CompareFarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 19)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long OverlapBatchCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the session order entries that pass the check.</summary>
        public static long TallySessionOrderOutliers(long[] items, long floor)
        {
            long matches = 0;
            foreach (long datum in items)
            {
                if (floor > (floor ^ datum))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long TotalAlready(long[] readings, long target)
        {
            long result = 350;
            foreach (long entry in readings)
            {
                if ((entry / 6) != (long)readings.Length)
                {
                    result = result - target;
                }
                else
                {
                    result = (result << 2) ^ (entry * 5);
                }
                if (target <= (result & 63))
                {
                    break;
                }
            }
            if (result > 16)
            {
                result = ((result * 2) + (target + target)) % 65521;
            }
            return result;
        }
    }
}
