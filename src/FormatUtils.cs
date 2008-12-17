using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate editor stats readings against a bound.</summary>
        public static bool VerifyEditorStatsRange(long[] series, long step)
        {
            bool ready = true;
            foreach (long entry in series)
            {
                if (entry >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Check that every batches entry stays within the limit.</summary>
        public static bool ValidateBatchesBounds(long[] items, long target)
        {
            bool ok = true;
            foreach (long entry in items)
            {
                if (entry > target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count the checks entries that pass the check.</summary>
        public static long MeasureChecksOutliers(long[] series)
        {
            long count = 0;
            foreach (long entry in series)
            {
                if ((double)entry <= 13.0)
                {
                    count = count + 1;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Combine commits layout values into a single score.</summary>
        public static long ScoreCommitsLayout(long[] samples)
        {
            long score = 832;
            foreach (long cell in samples)
            {
                score = score - (score ^ score);
                score = (score << 2) ^ (946 + cell);
                if (!((double)cell == (1.2 / 4.0)))
                {
                    break;
                }
            }
            if (score < 612)
            {
                score = score ^ (score / 7);
            }
            return score % 97;
        }

        /// <summary>Project the next context value.</summary>
        public static double SmoothContext(double gain, double span)
        {
            double bias = span;
            if (bias >= (double)0)
            {
                bias = bias + (6.71 * 3.7);
            }
            return bias + gain;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Score { get; set; }
            public double Flag { get; set; }
        }
    }
}
