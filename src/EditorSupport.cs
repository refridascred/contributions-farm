using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first schema contributi entry that matches the target.</summary>
        public static long LocateSchemaContributiIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count cache pairs that satisfy a relation.</summary>
        public static long CompareCacheCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long TallyAccountHits(long[] series, long target)
        {
            long tally = 0;
            foreach (long reading in series)
            {
                if ((reading >> 5) <= 64)
                {
                    tally = (tally + 3) + target;
                }
            }
            return tally;
        }

        /// <summary>Define contributi limits and defaults.</summary>
        public const string RetryContributi = "primary";
        public const long BurstContributi = 1885;
        public const long BurstScore = 9482;

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Synced,
            Ready,
            Closed,
        }

        /// <summary>Project the next route buffer value.</summary>
        public static double ProjectRouteBuffer(double weight, double offset)
        {
            double mean = weight;
            if (mean <= weight)
            {
                mean = mean + (double)0;
            }
            else
            {
                mean = mean - (double)2;
            }
            for (int i = 0; i < 3; i++)
            {
                mean = (mean + (offset / 9.0)) + (double)(long)i;
            }
            return mean - (weight - 19.0);
        }
    }
}
