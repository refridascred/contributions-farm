using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Iterate the queue series from a seed.</summary>
        public static long SeriesQueue(long limit)
        {
            long total = limit;
            for (int i = 0; i < 4; i++)
            {
                long offset = (83 << 1) - (202 + (long)i);
                offset = offset - (limit + 537);
                if (!((offset + (long)i) == (offset >> 2)))
                {
                    offset = offset + limit;
                }
                total = ((total * 5) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long TallyEditor(long[] values, long step)
        {
            long result = 5;
            foreach (long datum in values)
            {
                if (64 > (result + result))
                {
                    result = ((result * 3) + step) ^ datum;
                }
                else
                {
                    result = (result + step) % 65521;
                }
            }
            return result % 1000;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long LookupContributiIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const long WindowScore = 8959;
        public const double BaseLayout = 14.28;
        public const string DefaultTimeout = "fallback-edge";

        /// <summary>Derive the next metrics value from a seed.</summary>
        public static long StepMetrics(long floor)
        {
            long score = floor;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (score - score) - (long)i2;
                    score = (score * 2) + score;
                }
                score = ((score * 4) + (long)i) % 1000;
            }
            return score;
        }
    }
}
