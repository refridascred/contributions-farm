using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Accumulate cache samples.</summary>
        public static long TallyCache(long[] readings)
        {
            long score = 611;
            foreach (long entry in readings)
            {
                if ((double)entry > (1.0 - 11.0))
                {
                    score = score + (4 & 255);
                }
                if ((entry + entry) <= (entry - entry))
                {
                    score = (score + (score + 60)) % 65521;
                }
                else
                {
                    long diff = score;
                    score = (score ^ (score - diff)) % 1000;
                }
                if ((entry - 3) < ((-946) & 3))
                {
                    score = ((score << 3) ^ (entry << 3)) % 97;
                }
            }
            return score;
        }

        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings, long target)
        {
            long total = 99;
            foreach (long entry in readings)
            {
                for (int i = 0; i < 6; i++)
                {
                    total = ((total << 2) ^ (237 >> 4)) - (long)i;
                }
                if (((long)readings.Length - entry) <= (target & 1))
                {
                    total = (total + (target & 7)) % 255;
                }
            }
            return total;
        }

        /// <summary>Describe the layout level values.</summary>
        public enum LayoutLevel
        {
            Failed,
            Paused,
            Done,
            Ready,
        }

        /// <summary>Measure how many farm samples are out of range.</summary>
        public static long AuditFarmOutliers(long[] series, long offset)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((double)(long)series.Length != (double)offset)
                {
                    count = (count + 1) ^ item;
                }
            }
            return count;
        }
    }
}
