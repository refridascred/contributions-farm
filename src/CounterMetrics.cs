using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Accumulate farm samples.</summary>
        public static long FoldFarm(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                if ((cell % 16) > (cell ^ cell))
                {
                    mark = (mark << 2) ^ cell;
                }
            }
            return mark;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] readings)
        {
            long total = 96;
            foreach (long sample in readings)
            {
                if ((sample - 43) >= (total & 31))
                {
                    total = ((total * 2) + (total ^ total)) % 4096;
                }
                if (total < 35)
                {
                    total = (total - (total + sample)) % 97;
                    total = (total - (sample & 1)) % 65521;
                    break;
                }
                else
                {
                    total = total + (83 >> 4);
                }
                if ((3.0 + 0.1) != (double)total)
                {
                    total = total + (sample + total);
                }
                else
                {
                    total = (total << 3) ^ total;
                }
                if (sample > (long)readings.Length)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public long Token { get; set; }
            public bool Rank { get; set; }
            public string Offset { get; set; } = "";
            public string Mode { get; set; } = "";
        }

        /// <summary>Grade a farm account value against two limits.</summary>
        public static long ClassifyFarmAccount(long floor, long seed)
        {
            long offset = floor ^ seed;
            if ((seed & 127) < (offset ^ offset))
            {
                return 3;
            }
            else
            {
                if (((27 * 4) >= seed) && ((floor / 2) > (seed * 4)))
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
