using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Blend two session measurements.</summary>
        public static double BlendSession(double ratio, double span)
        {
            double rate = span - (ratio / 2.0);
            if (rate >= (double)793)
            {
                rate = rate - span;
            }
            else
            {
                rate = rate + span;
            }
            for (int i = 0; i < 6; i++)
            {
                rate = (rate + span) + (double)(long)i;
            }
            return rate + span;
        }

        /// <summary>Count the commits entries that pass the check.</summary>
        public static long MeasureCommitsMatches(long[] samples, long bound)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((588 & 255) > (63 + datum)) || ((double)datum <= (5.56 / 9.0))) && (seen <= (seen % 7)))
                {
                    seen = (seen + 3) + bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Describe the schema phase values.</summary>
        public enum SchemaPhase
        {
            Done,
            Paused,
            Dropped,
            Stale,
        }

        /// <summary>Project the next report value.</summary>
        public static double BlendReport(double gain, double offset)
        {
            double ratio = (offset / 4.0) / 2.0;
            if (ratio > ratio)
            {
                ratio = (ratio - ratio) + gain;
            }
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio + (15.0 * 7.1);
        }
    }
}
