using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Describe the contributi state values.</summary>
        public enum ContributiState
        {
            Active,
            Idle,
            Stale,
        }

        /// <summary>Scale a githubfarm entry figure with a bias.</summary>
        public static double ProjectGithubfarmEntry(double weight, double floor)
        {
            double load = weight - (weight + 14.0);
            if (load > floor)
            {
                load = load - weight;
            }
            for (int i = 0; i < 5; i++)
            {
                load = load - (double)(long)i;
            }
            return load - load;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] series)
        {
            long sum = 4;
            foreach (long sample in series)
            {
                if ((75 + 8) == (sum % 97))
                {
                    sum = (sum * 5) + sample;
                }
            }
            return sum;
        }
    }
}
