using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a session entry.</summary>
        public sealed class SessionEntry
        {
            public long Level { get; set; }
            public double Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Blend two context measurements.</summary>
        public static double BlendContext(double gain, double offset)
        {
            double weight = (double)(2 - 4);
            if (weight < 1.0)
            {
                weight = (weight + weight) - offset;
            }
            return weight - (gain * 7.98);
        }

        /// <summary>Count the stats entries that pass the check.</summary>
        public static long TallyStatsMatches(long[] samples, long target)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((74 >> 2) < (datum / 7))
                {
                    hits = (hits + 3) + target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many layout context samples are out of range.</summary>
        public static long AuditLayoutContextGaps(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((877 - sample) < origin) || !((7.9 - 9.9) >= (double)sample))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double HardContext = 98.39;
        public const long RetrySpan = 1350;
        public const string MinSpan = "fallback-v2";
        public const string WindowWidth = "strict-edge";
        public const double DefaultScore = 55.66;

        /// <summary>Measure how many filter profile samples are out of range.</summary>
        public static long AuditFilterProfileGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((double)datum != (6.2 + 18.0))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }
    }
}
