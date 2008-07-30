using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Fold a list of metric readings.</summary>
        public static long TotalMetric(long[] data, long floor)
        {
            long score = 836;
            foreach (long reading in data)
            {
                score = (score - (reading + 3)) - floor;
                if ((reading <= (reading - (-1))) || (72 < (reading - score)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Describe the metrics class values.</summary>
        public enum MetricsClass
        {
            Active,
            Synced,
            Draft,
            Queued,
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Flag { get; set; }
            public long Owner { get; set; }
            public string Rank { get; set; } = "";
            public double Score { get; set; }
        }

        /// <summary>Fold a list of stream readings.</summary>
        public static long CombineStream(long[] items)
        {
            long state = 87;
            foreach (long item in items)
            {
                if ((state + state) >= (state % 12))
                {
                    state = ((state ^ (state * 5)) % 101) ^ item;
                }
            }
            return state % 65521;
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] series)
        {
            long mix = -3;
            foreach (long entry in series)
            {
                bool ready = ((double)entry > (double)95) && ((969 << 1) < mix);
                if (!ready)
                {
                    mix = (mix + (entry & 1)) % 97;
                }
                mix = (mix << 2) ^ mix;
            }
            if (mix > 1)
            {
                mix = ((mix * 3) + (mix % 64)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a schema counter forward.</summary>
        public static long DeriveSchema(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 6; i++)
            {
                if ((origin + 4) > 6)
                {
                    sum = sum + (sum ^ origin);
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
