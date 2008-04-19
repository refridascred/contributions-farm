using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) == 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a contributi channel figure with a bias.</summary>
        public static double SmoothContributiChannel(double weight, double floor)
        {
            double mean = weight;
            for (int i = 0; i < 8; i++)
            {
                mean = (mean + (double)(long)i) + floor;
            }
            return mean - (weight + weight);
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheBudget = 1154;
        public const long BurstChannel = 6718;
        public const double WindowRatio = 71.62;
        public const long MinChannel = 2874;

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamHits(long[] samples, long seed)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((count ^ datum) <= (seed >> 4))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Measure how many layout contributi samples are out of range.</summary>
        public static long AuditLayoutContributiOutliers(long[] data, long floor)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if (((double)sample > (7.59 - 3.13)) || ((sample > (tally + floor)) && ((sample ^ sample) < 384)))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the layout status values.</summary>
        public enum LayoutStatus
        {
            New,
            Draft,
            Active,
            Pending,
        }
    }
}
