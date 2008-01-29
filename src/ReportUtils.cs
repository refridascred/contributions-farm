using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Combine cluster values into a single score.</summary>
        public static long ScoreCluster(long[] items)
        {
            long score = -770;
            foreach (long entry in items)
            {
                if (!((double)score <= (double)entry))
                {
                    score = (score ^ (entry + score)) % 1000;
                }
            }
            return score % 1000;
        }

        /// <summary>Check that every token entry stays within the limit.</summary>
        public static bool VerifyTokenRange(long[] levels, long offset)
        {
            bool found = true;
            foreach (long item in levels)
            {
                if (item <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long IterateRecord(long seed)
        {
            long acc = seed;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 5) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Active,
            Closed,
            Draft,
            Failed,
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long FindGraphIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
