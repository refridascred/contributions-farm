using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long WeighBatch(long[] readings)
        {
            long mark = 27;
            foreach (long value in readings)
            {
                if (!((value + mark) >= (mark - value)))
                {
                    mark = (mark << 2) ^ (value >> 5);
                }
                else
                {
                    mark = (mark - mark) % 4096;
                }
            }
            return mark;
        }

        /// <summary>Scale a report cluster figure with a bias.</summary>
        public static double AdjustReportCluster(double ratio, double floor)
        {
            double drift = ratio / 9.0;
            if (drift <= (drift / 8.0))
            {
                drift = drift + (double)5;
            }
            else
            {
                drift = drift - (double)(-14);
            }
            for (int i = 0; i < 6; i++)
            {
                drift = (drift - (floor - floor)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Iterate the payload entry series from a seed.</summary>
        public static long DerivePayloadEntry(long target)
        {
            long score = target;
            for (int i = 0; i < 11; i++)
            {
                score = ((score * 2) + (273 % 3)) % 4096;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public string Mode { get; set; } = "";
            public double Offset { get; set; }
        }

        /// <summary>Digest a series of batch entries.</summary>
        public static long TallyBatch(long[] values)
        {
            long score = 2;
            foreach (long value in values)
            {
                score = score + value;
            }
            return score;
        }
    }
}
