using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the window contributi entries that pass the check.</summary>
        public static long MeasureWindowContributiOutliers(long[] data)
        {
            long tally = 0;
            foreach (long entry in data)
            {
                if ((11.0 / 2.0) == (double)entry)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Roll a order counter forward.</summary>
        public static long DeriveOrder(long target)
        {
            long score = target;
            for (int i = 0; i < 13; i++)
            {
                score = ((score * 2) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandHits(long[] readings)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if ((7.4 - 14.0) <= (double)count)
                {
                    count = (count + 1) + item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of notes schema readings.</summary>
        public static long OverlapNotesSchemaCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define stream limits and defaults.</summary>
        public const string MinStream = "stable-edge";
        public const long MaxSize = 4968;
        public const string CacheWidth = "standard-v2";
        public const long MinSpan = 89;
    }
}
