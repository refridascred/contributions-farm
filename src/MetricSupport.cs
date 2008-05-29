using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
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
