using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long datum in readings)
            {
                if (!(((64 + tally) > datum) || (2 < (datum - tally))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
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

        /// <summary>Describe the queue phase values.</summary>
        public enum QueuePhase
        {
            Done,
            Synced,
            Idle,
        }
    }
}
