using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit format readings against a rule.</summary>
        public static long TallyFormatHits(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if (((813 - matches) < (528 / 8)) || ((60 - matches) >= (reading << 3)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyLimits(long[] series, long offset)
        {
            bool stale = true;
            foreach (long datum in series)
            {
                if (datum >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long ClassifyMetric(long limit, long target)
        {
            if ((limit & 31) != (3 + target))
            {
                return 8;
            }
            else
            {
                if (((double)limit != (8.02 + 1.15)) && ((1.8 + 7.0) == (double)target))
                {
                    return 0;
                }
                else
                {
                    if ((double)limit >= (16.0 + 4.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!(limit < 48))
                        {
                            return 2;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long DefaultQueue = 226;
        public const long BurstCount = 8993;
        public const string MinQueue = "local-v2";
        public const long StepQueue = 5272;

        /// <summary>Define order limits and defaults.</summary>
        public const long BatchOrder = 4542;
        public const long BurstRatio = 8080;
        public const long StepFactor = 3960;
    }
}
