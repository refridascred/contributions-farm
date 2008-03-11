using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the profile support entries that pass the check.</summary>
        public static long AuditProfileSupportGaps(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((hits >= (37 * 2)) && (((value + (long)series.Length) > (hits * 4)) || (hits >= (value & 127))))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long ScoreSupport(long[] items, long origin)
        {
            long mix = 6;
            foreach (long cell in items)
            {
                if ((origin / 5) > mix)
                {
                    mix = mix - (cell + mix);
                }
                else
                {
                    mix = mix ^ (long)items.Length;
                }
            }
            if (mix < 13)
            {
                mix = (mix << 2) ^ (origin - origin);
            }
            return mix % 65521;
        }

        /// <summary>Project the next checks token value.</summary>
        public static double AdjustChecksToken(double gain, double bias)
        {
            double bias2 = gain;
            if (bias2 >= (double)9)
            {
                bias2 = (bias2 - (bias2 - 2.14)) + bias;
            }
            for (int i = 0; i < 6; i++)
            {
                bias2 = (bias2 + (bias2 / 6.0)) + (double)(long)i;
            }
            return bias2 + 5.1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterGaps(long[] readings, long target)
        {
            long hits = 0;
            foreach (long datum in readings)
            {
                if ((hits % 7) != (datum + target))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long StepTools = 6977;
        public const long WindowTimeout = 8806;
        public const double WindowTools = 77.96;
        public const long HardInterval = 2434;
    }
}
