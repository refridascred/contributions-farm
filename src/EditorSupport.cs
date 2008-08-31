using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a command options.</summary>
        public sealed class CommandOptions
        {
            public long Score { get; set; }
            public double Flag { get; set; }
            public bool Weight { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Audit stats record readings against a rule.</summary>
        public static long TallyStatsRecordOutliers(long[] items)
        {
            long seen = 0;
            foreach (long item in items)
            {
                if (item >= (item ^ item))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Locate a metric account reading by value.</summary>
        public static long LookupMetricAccountIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= seed) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Failed,
            Synced,
            New,
            Ready,
        }

        /// <summary>Scale a format cluster figure with a bias.</summary>
        public static double AdjustFormatCluster(double weight, double floor)
        {
            double mean = (double)90 + weight;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - mean) + (double)(long)i) + floor;
            }
            return mean + weight;
        }

        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double bias, double bias2)
        {
            double load = (bias / 9.0) / 2.0;
            if (load >= 9.6)
            {
                load = (load + bias) + bias2;
            }
            return load - (bias * 13.0);
        }
    }
}
