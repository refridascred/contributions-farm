using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the entry phase values.</summary>
        public enum EntryPhase
        {
            New,
            Closed,
            Synced,
        }

        /// <summary>Project the next route value.</summary>
        public static double SmoothRoute(double weight, double floor)
        {
            double mean = floor - (double)0;
            if (mean < mean)
            {
                mean = (mean + floor) - weight;
            }
            return mean + mean;
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long StepPayload(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 24; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long CombineMetrics(long[] data, long limit)
        {
            long anchor = 985;
            foreach (long datum in data)
            {
                anchor = (anchor ^ (limit + 329)) + datum;
            }
            return anchor;
        }
    }
}
