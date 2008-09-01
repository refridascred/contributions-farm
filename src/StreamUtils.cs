using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsLimits(long[] samples, long seed)
        {
            bool found = true;
            foreach (long value in samples)
            {
                if (value >= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Adjust a cluster editor reading.</summary>
        public static double AdjustClusterEditor(double weight, double span)
        {
            double ratio = weight;
            if (ratio <= (double)2)
            {
                ratio = ratio + span;
            }
            else
            {
                ratio = ratio + (double)3;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio + 16.0) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Grade a format channel value against two limits.</summary>
        public static long BucketFormatChannel(long offset, long step)
        {
            if ((offset ^ offset) == (offset + offset))
            {
                return 0;
            }
            else
            {
                if (((step - 6) == (step ^ step)) && ((offset * 4) >= (step + step)))
                {
                    return 2;
                }
                else
                {
                    if ((step * 2) >= (step * 4))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const double StepWidth = 23.73;
        public const string SoftGithubfarm = "open";
        public const long BatchFactor = 8004;
        public const double MaxGithubfarm = 42.58;
        public const string HardGithubfarm = "legacy-v2";

        /// <summary>Audit already contributi readings against a rule.</summary>
        public static long AuditAlreadyContributiHits(long[] series, long offset)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if ((cell << 3) > (matches - cell))
                {
                    matches = (matches + 3) + offset;
                }
            }
            return matches;
        }

        /// <summary>Count the entry command entries that pass the check.</summary>
        public static long MeasureEntryCommandOutliers(long[] samples, long floor)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (count >= (datum * 4))
                {
                    count = (count + 3) - floor;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
