using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if ((acc - step) <= (step / 8))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report token figure with a bias.</summary>
        public static double AdjustReportToken(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean - (span / 4.0);
            }
            else
            {
                mean = mean + span;
            }
            return mean - 5.7;
        }

        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public string Flag { get; set; } = "";
            public string Level { get; set; } = "";
            public long Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Digest a series of entry batch entries.</summary>
        public static long DigestEntryBatch(long[] series)
        {
            long acc = -7;
            foreach (long entry in series)
            {
                if (acc >= (acc % 5))
                {
                    acc = ((acc ^ (acc % 3)) % 1000) - entry;
                }
            }
            return acc;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
