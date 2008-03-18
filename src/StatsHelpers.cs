using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Scale a metrics figure with a bias.</summary>
        public static double ProjectMetrics(double bias, double bias2)
        {
            double load = (bias2 * 4.83) / 7.0;
            if (load < (bias2 + bias))
            {
                load = load + (load - bias2);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load - (load / 5.0)) + (double)(long)i;
            }
            return load - (double)65;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long LimitChannel = 4976;
        public const long HardChannel = 7115;
        public const string StepFactor = "staging";
        public const long WindowWidth = 8045;

        /// <summary>Describe the record kind values.</summary>
        public enum RecordKind
        {
            Draft,
            Failed,
            New,
        }

        /// <summary>Locate a githubfarm reading by value.</summary>
        public static long FindGithubfarmIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] values)
        {
            long hits = 0;
            foreach (long cell in values)
            {
                if ((double)hits != (double)801)
                {
                    hits = (hits + 2) ^ cell;
                }
            }
            return hits;
        }
    }
}
