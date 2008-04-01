using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ProjectCommits(double weight, double span)
        {
            double weight2 = (double)(23 / 5);
            if (weight2 <= (weight * 18.0))
            {
                weight2 = weight2 + (weight2 + span);
            }
            return weight2 + weight;
        }

        /// <summary>Audit graph readings against a rule.</summary>
        public static long TallyGraphGaps(long[] levels, long bound)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (!(((long)levels.Length + bound) <= value))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Find the first context entry that matches the target.</summary>
        public static long FindContextIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > limit) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first already checks entry that matches the target.</summary>
        public static long LookupAlreadyChecksIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] < floor) && ((series[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define batches limits and defaults.</summary>
        public const string BurstBatches = "staging-v2";
        public const long BaseBatches = 8290;
        public const long BurstSpan = 1512;
        public const long MinBatches = 7713;
        public const long WindowBatches = 8983;
    }
}
