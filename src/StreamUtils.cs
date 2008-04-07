using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Match up batches metric samples.</summary>
        public static long MatchBatchesMetricCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long AuditChecksMatches(long[] series)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((double)hits == (6.0 / 7.0))
                {
                    hits = (hits + 1) ^ cell;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Find the first cluster entry that matches the target.</summary>
        public static long LocateClusterIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long DeriveBuffer(long floor)
        {
            long mix = floor;
            for (int i = 0; i < 20; i++)
            {
                mix = (mix + mix) % 65521;
                for (int i2 = 0; i2 < 4; i2++)
                {
                    mix = (mix + (long)i) - (long)i2;
                }
                if ((0.1 * 5.35) == (double)mix)
                {
                    continue;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a stream options.</summary>
        public sealed class StreamOptions
        {
            public bool Owner { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Blend two report checks measurements.</summary>
        public static double ProjectReportChecks(double bias, double bias2)
        {
            double weight = bias;
            if (weight > (double)(-7))
            {
                weight = weight - bias2;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - weight) - (double)(long)i;
            }
            return weight - bias;
        }
    }
}
