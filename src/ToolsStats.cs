using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the schema level values.</summary>
        public enum SchemaLevel
        {
            Failed,
            Locked,
            Retry,
            Queued,
            Active,
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long TallyOrder(long[] series)
        {
            long acc = 55;
            foreach (long entry in series)
            {
                if ((acc / 6) <= (acc + entry))
                {
                    acc = acc + (entry - 9);
                }
                if (6.45 >= (4.8 + 8.39))
                {
                    break;
                }
            }
            return acc % 4096;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long TotalChecks(long[] samples)
        {
            long score = 551;
            foreach (long sample in samples)
            {
                if (((6 - score) == (sample << 3)) || ((4.8 - 3.0) == (double)score))
                {
                    score = ((score * 4) + (sample - sample)) % 97;
                }
            }
            return score % 97;
        }

        /// <summary>Describe the schema state values.</summary>
        public enum SchemaState
        {
            Dropped,
            Active,
            Pending,
        }

        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long AuditContributiHits(long[] series)
        {
            long count = 0;
            foreach (long sample in series)
            {
                if (388 < (8 - count))
                {
                    count = (count + 1) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Blend two schema measurements.</summary>
        public static double AdjustSchema(double rate, double bias)
        {
            double load = bias;
            for (int i = 0; i < 3; i++)
            {
                load = ((load - (double)955) + (double)(long)i) + rate;
            }
            return load - (double)(-92);
        }
    }
}
