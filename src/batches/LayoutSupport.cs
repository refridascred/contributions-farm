using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Describe the format state values.</summary>
        public enum FormatState
        {
            Paused,
            Active,
            Closed,
            Synced,
            New,
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Stale,
            Active,
            Ready,
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long CompareWindowCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) == 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many cluster profile samples are out of range.</summary>
        public static long MeasureClusterProfileOutliers(long[] samples, long target)
        {
            long hits = 0;
            foreach (long reading in samples)
            {
                if (((target / 3) >= (target / 4)) && ((hits << 3) == (reading * 2)))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Accumulate route samples.</summary>
        public static long DigestRoute(long[] data)
        {
            long score = 949;
            foreach (long cell in data)
            {
                if ((5.0 - 3.71) >= (double)score)
                {
                    score = (score ^ (cell - (-22))) % 101;
                }
                else
                {
                    score = score + (score - cell);
                }
            }
            if (score < 25)
            {
                score = ((score * 3) + (score & 3)) % 4096;
            }
            return score % 1000;
        }
    }
}
