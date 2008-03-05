using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit contributi account readings against a rule.</summary>
        public static long MeasureContributiAccountMatches(long[] items)
        {
            long tally = 0;
            foreach (long datum in items)
            {
                if ((tally + tally) == (datum + datum))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Hold a already options.</summary>
        public sealed class AlreadyOptions
        {
            public long Flag { get; set; }
            public bool Region { get; set; }
            public bool Ratio { get; set; }
            public bool Count { get; set; }
        }

        /// <summary>Measure how many metrics samples are out of range.</summary>
        public static long AuditMetricsHits(long[] readings)
        {
            long matches = 0;
            foreach (long value in readings)
            {
                if ((value - matches) < matches)
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long WindowEditor = 8292;
        public const double BatchEditor = 73.45;
        public const long MaxTimeout = 5162;
        public const double IdleCount = 24.82;

        /// <summary>Adjust a editor metric reading.</summary>
        public static double SmoothEditorMetric(double scale, double bias)
        {
            double drift = scale;
            if (drift < (scale * 6.6))
            {
                drift = (drift - (drift * 3.3)) - bias;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift - (double)968) - (double)(long)i;
            }
            return drift + scale;
        }

        /// <summary>Project the next already value.</summary>
        public static double BlendAlready(double scale, double bias)
        {
            double weight = (double)534 / 5.0;
            if (weight >= weight)
            {
                weight = (weight + (double)(-6)) - bias;
            }
            else
            {
                weight = weight + 2.12;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + (scale / 5.0)) + (double)(long)i;
            }
            return weight + weight;
        }
    }
}
