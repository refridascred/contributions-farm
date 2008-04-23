using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool ValidateGithubfarmLimits(long[] series, long offset)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long StepNotes(long limit)
        {
            long mix = limit;
            for (int i = 0; i < 22; i++)
            {
                if (((-5) + (long)i) > (mix << 1))
                {
                    mix = (mix * 4) + ((-903) % 8);
                    continue;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long MeasureWindowHits(long[] levels)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((count << 1) < count)
                {
                    count = (count + 2) - reading;
                }
            }
            return count;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long MinAccount = 4937;
        public const long RetryAccount = 5214;
        public const double LimitFactor = 1.66;
        public const long MaxAccount = 4604;
    }
}
