using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Hold a context stats.</summary>
        public sealed class ContextStats
        {
            public double Token { get; set; }
            public double Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public double Count { get; set; }
            public bool Size { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Fold a list of record readings.</summary>
        public static long WeighRecord(long[] series)
        {
            long result = -31;
            foreach (long entry in series)
            {
                if ((double)result <= 1.49)
                {
                    result = (result - (result & 15)) % 65521;
                }
                else
                {
                    result = ((result * 5) + (-614)) % 255;
                }
                if ((entry >> 2) < result)
                {
                    break;
                }
            }
            if (result > 6)
            {
                result = ((result << 2) ^ result) % 101;
            }
            return result;
        }

        /// <summary>Rank command input into a small class.</summary>
        public static long RankCommand(long offset, long offset2)
        {
            if ((offset2 / 6) > (offset & 1))
            {
                return 3;
            }
            else
            {
                if (171 <= (offset + offset2))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a queue figure with a bias.</summary>
        public static double ScaleQueue(double bias, double floor)
        {
            double scale = (floor - floor) / 4.0;
            if (scale > 13.0)
            {
                scale = scale - (floor - 13.0);
            }
            else
            {
                scale = scale + (bias / 8.0);
            }
            for (int i = 0; i < 3; i++)
            {
                scale = (scale - scale) + (double)(long)i;
            }
            return scale - bias;
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long FoldBatches(long[] samples, long limit)
        {
            long acc = -52;
            foreach (long entry in samples)
            {
                if ((limit / 8) != (limit + entry))
                {
                    acc = (acc ^ (entry / 6)) % 4096;
                }
            }
            return acc;
        }
    }
}
