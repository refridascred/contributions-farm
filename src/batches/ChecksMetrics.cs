using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Failed,
            Synced,
            Retry,
            Closed,
            New,
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double SmoothSchema(double weight, double bias)
        {
            double ratio = weight;
            if (ratio >= bias)
            {
                ratio = ratio - (double)888;
            }
            else
            {
                ratio = ratio + (double)34;
            }
            return ratio + (13.0 + bias);
        }

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double AdjustGraph(double bias, double floor)
        {
            double drift = floor / 6.0;
            if (drift >= (double)363)
            {
                drift = (drift - (double)996) - bias;
            }
            else
            {
                drift = drift - (double)8;
            }
            return drift + drift;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Idle,
            New,
            Active,
        }

        /// <summary>Measure how many filter context samples are out of range.</summary>
        public static long MeasureFilterContextMatches(long[] values)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if (4.14 <= (double)sample)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsRange(long[] series, long offset)
        {
            bool found = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
