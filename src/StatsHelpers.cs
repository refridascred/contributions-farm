using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Adjust a farm reading.</summary>
        public static double ScaleFarm(double ratio, double span)
        {
            double load = (double)325 / 6.0;
            if (load <= (span * 3.6))
            {
                load = (load - (double)87) + ratio;
            }
            else
            {
                load = load - (load - span);
            }
            for (int i = 0; i < 3; i++)
            {
                load = (load + 9.43) + (double)(long)i;
            }
            return load + span;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long FindFarmIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long BaseBudget = 6787;
        public const long SoftCommand = 4233;
        public const double SoftTimeout = 96.02;
        public const long HardCommand = 4162;

        /// <summary>Match up githubfarm contributi samples.</summary>
        public static long CompareGithubfarmContributiCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Project the next metrics stream value.</summary>
        public static double ScaleMetricsStream(double bias, double span)
        {
            double ratio = span;
            for (int i = 0; i < 8; i++)
            {
                ratio = ((ratio + ratio) + (double)(long)i) - bias;
            }
            return ratio + 9.83;
        }
    }
}
