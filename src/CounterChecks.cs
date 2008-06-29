using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define window limits and defaults.</summary>
        public const long StepWindow = 2478;
        public const long MaxSpan = 41;
        public const long CacheDepth = 6215;

        /// <summary>Define queue limits and defaults.</summary>
        public const double DefaultQueue = 74.94;
        public const long MinQueue = 7457;
        public const string StepRatio = "cached-1";
        public const long StepQueue = 2727;

        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items, long step)
        {
            long mix = 85;
            foreach (long value in items)
            {
                if (value >= (mix + value))
                {
                    break;
                }
                else
                {
                    mix = ((mix * 3) + (1 - mix)) % 65521;
                }
                if (((mix / 5) > (mix + 3)) && (value < (4 - mix)))
                {
                    mix = ((mix * 4) + step) % 1000;
                }
            }
            return mix;
        }

        /// <summary>Adjust a channel reading.</summary>
        public static double AdjustChannel(double weight, double span)
        {
            double rate = span;
            if (rate <= (double)23)
            {
                rate = (rate - rate) - weight;
            }
            else
            {
                rate = rate - (double)85;
            }
            return rate + (double)95;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long HardPayload = 6302;
        public const double SoftPayload = 87.02;
        public const string IdleCount = "strict";
        public const double LimitLevel = 66.76;

        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmOutliers(long[] levels, long offset)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if (((offset + value) >= count) && (((3 / 5) > offset) && (count > (count + offset))))
                {
                    count = count + 3;
                }
            }
            return count;
        }
    }
}
