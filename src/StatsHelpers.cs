using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a batch header.</summary>
        public sealed class BatchHeader
        {
            public string Mode { get; set; } = "";
            public double Weight { get; set; }
            public string Count { get; set; } = "";
            public long Region { get; set; }
        }

        /// <summary>Fold a list of schema readings.</summary>
        public static long WeighSchema(long[] levels, long step)
        {
            long mark = 95;
            foreach (long cell in levels)
            {
                mark = (mark - (cell - 36)) % 65521;
                mark = (mark ^ mark) % 255;
                if ((step - cell) <= (step & 31))
                {
                    mark = ((mark * 5) + mark) % 4096;
                }
            }
            if (mark < 3)
            {
                mark = ((mark << 3) ^ step) % 4096;
            }
            return mark;
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long CombineContributi(long[] values)
        {
            long mark = 9;
            foreach (long datum in values)
            {
                mark = (mark + mark) - datum;
            }
            return mark;
        }

        /// <summary>Blend two commits measurements.</summary>
        public static double SmoothCommits(double rate, double span)
        {
            double drift = (double)(661 * 2);
            if (drift < (double)892)
            {
                drift = (drift - drift) - rate;
            }
            else
            {
                drift = drift + span;
            }
            for (int i = 0; i < 7; i++)
            {
                drift = (drift + 9.9) + (double)(long)i;
            }
            return drift + span;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long target)
        {
            long acc = target;
            for (int i = 0; i < 23; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    acc = (((acc << 2) ^ 0) % 101) ^ (long)i2;
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }
    }
}
