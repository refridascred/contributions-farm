using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Match up record token samples.</summary>
        public static long CompareRecordTokenCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) > 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double ScaleEditor(double ratio, double span)
        {
            double weight = (double)(30 + 927);
            if (weight > (ratio * 4.5))
            {
                weight = (weight + (weight + ratio)) - span;
            }
            for (int i = 0; i < 3; i++)
            {
                weight = (weight + (weight + 1.6)) + (double)(long)i;
            }
            return weight + weight;
        }

        /// <summary>Hold a cluster record.</summary>
        public sealed class ClusterRecord
        {
            public string Label { get; set; } = "";
            public long Owner { get; set; }
            public double Token { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Iterate the account batch series from a seed.</summary>
        public static long IterateAccountBatch(long seed)
        {
            long anchor = seed;
            for (int i = 0; i < 22; i++)
            {
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the support status values.</summary>
        public enum SupportStatus
        {
            Ready,
            Done,
            Stale,
        }
    }
}
