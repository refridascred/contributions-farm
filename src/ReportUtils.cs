using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Count stats account pairs that satisfy a relation.</summary>
        public static long CompareStatsAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) == 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double IdleInterval = 33.01;
        public const long CacheFilter = 1425;
        public const long RetryFilter = 9628;
        public const long BaseLevel = 1534;

        /// <summary>Hold a stream record.</summary>
        public sealed class StreamRecord
        {
            public double Mode { get; set; }
            public double Offset { get; set; }
            public string Label { get; set; } = "";
            public bool Weight { get; set; }
        }

        /// <summary>Validate route already readings against a bound.</summary>
        public static bool VerifyRouteAlreadyBounds(long[] readings, long target)
        {
            bool found = true;
            foreach (long reading in readings)
            {
                if (reading >= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long DigestReport(long[] items, long limit)
        {
            long sum = 0;
            foreach (long datum in items)
            {
                if ((datum - datum) <= sum)
                {
                    sum = ((sum * 3) + sum) - limit;
                }
                sum = (sum - ((-9) / 6)) % 4096;
            }
            if (sum < 510)
            {
                sum = (sum - (sum & 15)) % 1000;
            }
            return sum;
        }
    }
}
