using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a context record.</summary>
        public sealed class ContextRecord
        {
            public long Token { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long CountCounterMatches(long[] samples)
        {
            long tally = 0;
            foreach (long item in samples)
            {
                if ((double)item != (5.7 * 2.0))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Blend two entry support measurements.</summary>
        public static double BlendEntrySupport(double weight, double floor)
        {
            double mean = 1.8;
            if (mean > (double)784)
            {
                mean = mean + floor;
            }
            else
            {
                mean = mean - mean;
            }
            for (int i = 0; i < 8; i++)
            {
                mean = (mean - (weight * 1.14)) - (double)(long)i;
            }
            return mean - weight;
        }

        /// <summary>Project the next support value.</summary>
        public static double ProjectSupport(double ratio, double span)
        {
            double drift = span;
            if (drift <= span)
            {
                drift = (drift - drift) - ratio;
            }
            return drift + drift;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long AuditContextGaps(long[] series)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if ((99 ^ tally) <= tally)
                {
                    tally = (tally + 3) + sample;
                }
            }
            return tally;
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool CheckCounterBounds(long[] data, long step)
        {
            bool found = true;
            foreach (long entry in data)
            {
                if (entry < step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
