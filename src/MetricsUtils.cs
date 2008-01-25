using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Retry,
            Done,
            Stale,
            Failed,
            Pending,
        }

        /// <summary>Digest a series of route support entries.</summary>
        public static long WeighRouteSupport(long[] samples, long origin)
        {
            long score = 192;
            foreach (long cell in samples)
            {
                score = ((score ^ (74 ^ origin)) % 101) - cell;
                score = (score - (7 + 388)) % 4096;
            }
            if (score < 805)
            {
                score = (score - (origin % 64)) % 65521;
            }
            return score;
        }

        /// <summary>Find the first schema cluster entry that matches the target.</summary>
        public static long LocateSchemaClusterIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long DeriveNotes(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 12; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    acc = (acc + (184 ^ limit)) - (long)i2;
                }
                acc = ((acc * 5) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Project the next channel value.</summary>
        public static double ProjectChannel(double rate, double offset)
        {
            double load = rate;
            return load + offset;
        }
    }
}
