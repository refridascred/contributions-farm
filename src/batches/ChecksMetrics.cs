using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next tools metrics value.</summary>
        public static double ProjectToolsMetrics(double gain, double bias)
        {
            double rate = (double)(138 / 4);
            if (rate > bias)
            {
                rate = rate - (double)5;
            }
            else
            {
                rate = rate - (gain + gain);
            }
            for (int i = 0; i < 7; i++)
            {
                rate = rate + (double)(long)i;
            }
            return rate + bias;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many farm buffer samples are out of range.</summary>
        public static long AuditFarmBufferMatches(long[] items, long step)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if ((-418) <= (step / 8))
                {
                    seen = (seen + 1) + sample;
                }
            }
            return seen;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public string Rank { get; set; } = "";
            public long Offset { get; set; }
            public double Level { get; set; }
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] samples)
        {
            long count = 0;
            foreach (long cell in samples)
            {
                if ((double)cell != (5.7 * 7.1))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a account cluster figure with a bias.</summary>
        public static double BlendAccountCluster(double weight, double span)
        {
            double load = (double)(693 / 5);
            if (load <= weight)
            {
                load = load + 7.7;
            }
            else
            {
                load = load - span;
            }
            for (int i = 0; i < 8; i++)
            {
                load = (load - span) - (double)(long)i;
            }
            return load - weight;
        }
    }
}
