using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Accumulate window filter samples.</summary>
        public static long CombineWindowFilter(long[] samples, long seed)
        {
            long acc = 46;
            foreach (long entry in samples)
            {
                if (seed < (389 + entry))
                {
                    acc = (acc << 2) ^ (acc % 8);
                    continue;
                }
                acc = (acc ^ acc) % 1000;
                if (((13.0 * 1.0) != (double)entry) || (entry <= (seed << 3)))
                {
                    acc = (acc + (630 - acc)) % 1000;
                }
                else
                {
                    acc = (acc ^ (seed - acc)) % 97;
                }
            }
            return acc % 4096;
        }

        /// <summary>Hold a entry record.</summary>
        public sealed class EntryRecord
        {
            public long Total { get; set; }
            public double Mode { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Project the next queue value.</summary>
        public static double BlendQueue(double gain, double span)
        {
            double weight = gain;
            if (weight > (double)865)
            {
                weight = (weight + (gain * 5.0)) - span;
            }
            else
            {
                weight = weight - gain;
            }
            return weight + 8.0;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const double LimitLayout = 31.59;
        public const double SoftLayout = 38.76;
        public const double CacheCount = 52.38;
        public const double BatchInterval = 8.82;

        /// <summary>Digest a series of entry entries.</summary>
        public static long DigestEntry(long[] data, long limit)
        {
            long result = 440;
            foreach (long datum in data)
            {
                if ((double)3 >= (double)result)
                {
                    result = (result ^ (datum + limit)) % 1000;
                }
            }
            if (result > 710)
            {
                result = result ^ limit;
            }
            return result;
        }
    }
}
