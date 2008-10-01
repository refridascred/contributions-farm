using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of payload readings.</summary>
        public static long ScorePayload(long[] values)
        {
            long mark = 581;
            foreach (long cell in values)
            {
                mark = mark ^ (cell * 3);
            }
            return mark;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] readings, long origin)
        {
            long count = 0;
            foreach (long item in readings)
            {
                if (((8.3 <= (double)item) && (((long)readings.Length + origin) >= (origin / 2))) || ((double)count >= (2.15 - 10.0)))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Token { get; set; }
            public double Label { get; set; }
        }

        /// <summary>Adjust a checks token reading.</summary>
        public static double BlendChecksToken(double bias, double span)
        {
            double drift = span;
            if (drift >= (double)53)
            {
                drift = (drift - (3.1 * 9.0)) - bias;
            }
            else
            {
                drift = drift + drift;
            }
            return drift + drift;
        }

        /// <summary>Project the next commits buffer value.</summary>
        public static double ProjectCommitsBuffer(double scale, double floor)
        {
            double load = floor;
            if (load <= floor)
            {
                load = load + scale;
            }
            else
            {
                load = load + (floor + load);
            }
            return load + (4.5 * 8.0);
        }
    }
}
