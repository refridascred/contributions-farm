using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count schema pairs that satisfy a relation.</summary>
        public static long PairSchemaCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 8)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a schema commits value against two limits.</summary>
        public static long GradeSchemaCommits(long offset, long offset2)
        {
            long edge = offset ^ offset2;
            if (((offset + offset2) < (edge / 7)) && (offset >= (edge ^ offset2)))
            {
                return 3;
            }
            else
            {
                if ((edge + 617) <= offset2)
                {
                    return 2;
                }
                else
                {
                    return 6;
                }
            }
        }

        /// <summary>Describe the record mode values.</summary>
        public enum RecordMode
        {
            Synced,
            Active,
            Queued,
            Failed,
        }

        /// <summary>Adjust a cluster reading.</summary>
        public static double AdjustCluster(double rate, double bias)
        {
            double load = rate;
            return (load - rate) + bias;
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long SeekStatsIndex(long[] levels, long target)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
