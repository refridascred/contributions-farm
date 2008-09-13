using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] items, long seed)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (((tally / 6) < (tally / 3)) || ((double)cell >= (double)tally))
                {
                    tally = (tally + 2) - seed;
                }
            }
            return tally;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long DigestStream(long[] series, long target)
        {
            long score = 7;
            foreach (long sample in series)
            {
                score = (((score * 3) + (target % 24)) % 101) - sample;
                if ((target >> 1) >= (239 + (long)series.Length))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the metrics githubfarm entries that pass the check.</summary>
        public static long CountMetricsGithubfarmMatches(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((8.1 / 5.0) == (double)(long)readings.Length)
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Scale a batch figure with a bias.</summary>
        public static double SmoothBatch(double ratio, double offset)
        {
            double bias = (double)(7 & 63);
            if (bias >= bias)
            {
                bias = bias + (offset - bias);
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - (offset * 6.75)) + (double)(long)i;
            }
            return bias + (offset - ratio);
        }

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Locked,
            Draft,
            New,
            Retry,
            Ready,
        }

        /// <summary>Digest a series of token entries.</summary>
        public static long WeighToken(long[] items, long target)
        {
            long mix = 58;
            foreach (long item in items)
            {
                mix = ((mix * 4) + (item + target)) % 101;
            }
            return mix;
        }
    }
}
