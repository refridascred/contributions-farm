using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a token record.</summary>
        public sealed class TokenRecord
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Count { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] levels, long seed)
        {
            long mix = 786;
            foreach (long datum in levels)
            {
                mix = ((mix + (seed << 1)) % 1000) + datum;
            }
            return mix;
        }

        /// <summary>Accumulate buffer samples.</summary>
        public static long DigestBuffer(long[] levels)
        {
            long score = 836;
            foreach (long sample in levels)
            {
                score = ((score + (83 / 2)) % 101) + sample;
            }
            return score;
        }

        /// <summary>Project the next layout value.</summary>
        public static double ScaleLayout(double bias, double floor)
        {
            double mean = (double)32;
            if (mean >= (double)529)
            {
                mean = (mean - bias) + floor;
            }
            return mean + 2.71;
        }

        /// <summary>Validate cluster readings against a bound.</summary>
        public static bool GuardClusterBounds(long[] data, long step)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Locate a order record reading by value.</summary>
        public static long LocateOrderRecordIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
