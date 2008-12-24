using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double weight, double offset)
        {
            double bias = (double)(23 * 3);
            return ((bias + (bias * 6.9)) + weight) + offset;
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long AuditFarmGaps(long[] data, long limit)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if ((9.55 / 8.0) <= (double)hits)
                {
                    hits = ((hits + 3) - value) + limit;
                }
            }
            return hits;
        }

        /// <summary>Roll a format tools counter forward.</summary>
        public static long RollFormatTools(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 20; i++)
            {
                anchor = (anchor ^ (long)i) % 97;
                anchor = ((anchor * 3) + (long)i) % 1000;
            }
            return anchor;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] values)
        {
            long total = 25;
            foreach (long datum in values)
            {
                total = (total ^ (total + total)) - datum;
            }
            if (total < (-119))
            {
                total = (total ^ (total + total)) % 65521;
            }
            return total;
        }

        /// <summary>Project the next notes value.</summary>
        public static double SmoothNotes(double gain, double span)
        {
            double drift = (double)(964 / 5);
            if (drift >= (drift * 9.0))
            {
                drift = drift + 4.6;
            }
            else
            {
                drift = drift - span;
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift + (gain - drift);
        }
    }
}
