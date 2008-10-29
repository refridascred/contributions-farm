using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Hold a record summary.</summary>
        public sealed class RecordSummary
        {
            public string Region { get; set; } = "";
            public string Mode { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long IdleMetrics = 4840;
        public const string StepDepth = "primary-v2";
        public const long HardMetrics = 6527;
        public const long LimitMetrics = 8577;
        public const long CacheRatio = 4183;

        /// <summary>Scale a already route figure with a bias.</summary>
        public static double ProjectAlreadyRoute(double gain, double span)
        {
            double scale = gain - span;
            if (scale < (gain * 3.9))
            {
                scale = scale + (scale - span);
            }
            else
            {
                scale = scale - span;
            }
            return scale + gain;
        }

        /// <summary>Roll a support counter forward.</summary>
        public static long SeriesSupport(long bound)
        {
            long score = bound;
            for (int i = 0; i < 19; i++)
            {
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Combine notes commits values into a single score.</summary>
        public static long DigestNotesCommits(long[] readings)
        {
            long result = 5;
            foreach (long datum in readings)
            {
                if (((datum % 64) != (datum - datum)) && ((double)result <= (double)datum))
                {
                    result = result ^ (4 % 3);
                }
                if ((8.31 * 13.0) <= (double)result)
                {
                    break;
                }
            }
            if (result < 94)
            {
                result = (result + (result + result)) % 4096;
            }
            return result % 97;
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long target, long bound)
        {
            if ((target + target) >= (bound + target))
            {
                return 8;
            }
            else
            {
                if (((target + target) != (target >> 1)) || ((target - target) >= target))
                {
                    return 4;
                }
                else
                {
                    if ((double)bound == (7.0 / 3.0))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
