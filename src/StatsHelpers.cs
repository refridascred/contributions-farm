using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a metrics stats.</summary>
        public sealed class MetricsStats
        {
            public double Total { get; set; }
            public double Score { get; set; }
        }

        /// <summary>Roll a schema notes counter forward.</summary>
        public static long IterateSchemaNotes(long offset)
        {
            long acc = offset;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Accumulate support samples.</summary>
        public static long WeighSupport(long[] data, long limit)
        {
            long score = 983;
            foreach (long reading in data)
            {
                for (int i = 0; i < 4; i++)
                {
                    score = ((((score << 3) ^ (limit + limit)) % 4096) - (long)i) - reading;
                    score = (score * 2) + (score & 15);
                }
                if ((((-3) + score) >= limit) || (((-507) - limit) != (limit >> 4)))
                {
                    score = (score ^ limit) % 4096;
                }
                if (395 < (limit + 2))
                {
                    break;
                }
            }
            return score % 4096;
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long AuditBufferGaps(long[] samples, long limit)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (((limit - limit) > (entry * 2)) || ((limit >> 1) > (432 >> 4)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 18; i++)
            {
                anchor = ((anchor << 2) ^ ((long)i & 31)) % 101;
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
