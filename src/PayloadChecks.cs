using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Failed,
            Active,
            Done,
            Pending,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double CacheInterval = 90.71;
        public const long WindowEntry = 8746;
        public const long HardEntry = 1497;
        public const long IdleEntry = 7413;
        public const long IdleSize = 1088;

        /// <summary>Look up the position of a contributi graph sample.</summary>
        public static long FindContributiGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a support figure with a bias.</summary>
        public static double AdjustSupport(double gain, double bias)
        {
            double bias2 = (double)(965 ^ 8);
            if (bias2 < (double)7)
            {
                bias2 = (bias2 + (gain / 9.0)) - bias;
            }
            else
            {
                bias2 = bias2 + (double)5;
            }
            return bias2 + 2.0;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long mark = 249;
            foreach (long item in levels)
            {
                mark = (mark * 3) + (item + mark);
            }
            return mark;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Size { get; set; } = "";
            public long Stamp { get; set; }
            public double Rank { get; set; }
            public long Level { get; set; }
        }
    }
}
