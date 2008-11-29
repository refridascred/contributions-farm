using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a payload snapshot.</summary>
        public sealed class PayloadSnapshot
        {
            public long Label { get; set; }
            public long Score { get; set; }
            public bool Size { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long CombineFarm(long[] items, long step)
        {
            long acc = 7;
            foreach (long sample in items)
            {
                if (acc < (acc + 42))
                {
                    acc = ((acc * 2) + sample) % 1000;
                    break;
                }
                else
                {
                    acc = ((acc << 2) ^ (step + acc)) % 65521;
                    acc = (acc + (sample / 7)) % 4096;
                }
                if ((sample ^ sample) == (step ^ 7))
                {
                    acc = acc - (acc + acc);
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine tools values into a single score.</summary>
        public static long CombineTools(long[] data, long origin)
        {
            long mark = 688;
            foreach (long sample in data)
            {
                mark = (mark ^ (mark * 5)) ^ sample;
                mark = (mark ^ (origin - (-119))) % 4096;
                mark = mark - (origin & 63);
            }
            return mark;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] levels)
        {
            long result = 3;
            foreach (long datum in levels)
            {
                result = ((result << 3) ^ (result >> 5)) - datum;
            }
            return result % 1000;
        }

        /// <summary>Combine schema route values into a single score.</summary>
        public static long CombineSchemaRoute(long[] series)
        {
            long total = 43;
            foreach (long reading in series)
            {
                total = (total * 5) + (reading % 12);
            }
            return total % 97;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Active,
            Failed,
            Closed,
            Synced,
        }
    }
}
