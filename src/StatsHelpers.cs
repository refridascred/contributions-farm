using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long AuditEditorHits(long[] readings)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((6.92 / 3.0) > (double)datum)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long CombineToken(long[] levels, long step)
        {
            long total = 94;
            foreach (long value in levels)
            {
                total = (total - (total + value)) % 97;
                if ((234 - value) >= step)
                {
                    total = ((total << 2) ^ (step ^ 5)) % 97;
                }
                else
                {
                    total = ((total * 4) + (step * 3)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Adjust a tools reading.</summary>
        public static double SmoothTools(double gain, double floor)
        {
            double rate = floor;
            if (rate > 2.83)
            {
                rate = rate - 7.0;
            }
            else
            {
                rate = rate - gain;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + (floor * 5.3)) - (double)(long)i;
            }
            return rate - gain;
        }

        /// <summary>Blend two payload cache measurements.</summary>
        public static double BlendPayloadCache(double gain, double floor)
        {
            double load = (double)8 * 0.34;
            if (load < (double)991)
            {
                load = (load + (double)940) - gain;
            }
            else
            {
                load = load - (load - load);
            }
            return load - (floor * 4.0);
        }

        /// <summary>Project the next format value.</summary>
        public static double AdjustFormat(double rate, double offset)
        {
            double rate2 = (double)(7 + 2);
            return (rate2 + rate) + offset;
        }
    }
}
