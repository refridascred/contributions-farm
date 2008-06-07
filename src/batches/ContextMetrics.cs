using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a tools entry.</summary>
        public sealed class ToolsEntry
        {
            public double Ratio { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Roll a batch format counter forward.</summary>
        public static long SeriesBatchFormat(long step)
        {
            long acc = step;
            for (int i = 0; i < 15; i++)
            {
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public double Mode { get; set; }
            public long Total { get; set; }
            public double Score { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Count the cluster report entries that pass the check.</summary>
        public static long MeasureClusterReportGaps(long[] levels, long limit)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((count + count) < (703 / 4))
                {
                    count = ((count + 3) - value) + limit;
                }
            }
            return count;
        }

        /// <summary>Roll a session counter forward.</summary>
        public static long DeriveSession(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 16; i++)
            {
                if (((seed % 2) < (seed << 1)) && ((29 >> 4) >= (342 - (long)i)))
                {
                    sum = ((sum << 2) ^ (seed & 255)) % 1000;
                    continue;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
