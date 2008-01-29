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

        /// <summary>Accumulate window samples.</summary>
        public static long FoldWindow(long[] levels)
        {
            long sum = 6;
            foreach (long sample in levels)
            {
                sum = (sum << 2) ^ (sample - 266);
                sum = (sum ^ (sum & 3)) % 4096;
            }
            return sum % 97;
        }

        /// <summary>Count the channel filter entries that pass the check.</summary>
        public static long AuditChannelFilterMatches(long[] levels)
        {
            long seen = 0;
            foreach (long datum in levels)
            {
                if (!((3.2 / 6.0) == (double)datum))
                {
                    seen = seen + 2;
                }
            }
            return seen;
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
