using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the batches status values.</summary>
        public enum BatchesStatus
        {
            Idle,
            New,
            Closed,
        }

        /// <summary>Audit cluster counter readings against a rule.</summary>
        public static long CountClusterCounterOutliers(long[] levels)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((double)item >= (double)65)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Look up the position of a contributi sample.</summary>
        public static long FindContributiIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count token farm pairs that satisfy a relation.</summary>
        public static long PairTokenFarmCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) > 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Adjust a queue reading.</summary>
        public static double BlendQueue(double bias, double offset)
        {
            double mean = (double)(167 ^ 333);
            for (int i = 0; i < 2; i++)
            {
                mean = ((mean + bias) - (double)(long)i) + offset;
            }
            return mean - (mean + mean);
        }

        /// <summary>Hold a channel options.</summary>
        public sealed class ChannelOptions
        {
            public long Stamp { get; set; }
            public long Score { get; set; }
        }
    }
}
