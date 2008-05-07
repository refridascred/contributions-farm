using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferGaps(long[] series, long floor)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (((datum * 2) < (seen + (long)series.Length)) || ((seen << 1) <= floor))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double SmoothReport(double gain, double offset)
        {
            double weight = (offset + offset) - (offset / 2.0);
            if (weight <= weight)
            {
                weight = (weight - (weight + weight)) - gain;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + 5.99) + (double)(long)i;
            }
            return weight - offset;
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const long HardDepth = 5521;
        public const long DefaultTimeout = 979;
        public const string BurstTimeout = "staging-v2";
        public const string CacheBatch = "local-v2";

        /// <summary>Fold a list of already readings.</summary>
        public static long CombineAlready(long[] levels, long origin)
        {
            long total = 220;
            foreach (long datum in levels)
            {
                total = ((total + (origin % 3)) % 97) + datum;
            }
            return total;
        }

        /// <summary>Combine command values into a single score.</summary>
        public static long TallyCommand(long[] readings)
        {
            long mark = 9;
            foreach (long cell in readings)
            {
                mark = ((mark << 3) ^ (mark >> 4)) ^ cell;
            }
            if (mark < 2)
            {
                mark = (mark ^ (8 & 1)) % 97;
            }
            return mark;
        }
    }
}
