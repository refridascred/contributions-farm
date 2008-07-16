using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Describe the format level values.</summary>
        public enum FormatLevel
        {
            Draft,
            Paused,
            Synced,
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long SeriesGithubfarm(long bound)
        {
            long mark = bound;
            for (int i = 0; i < 22; i++)
            {
                if ((bound ^ bound) >= (mark + mark))
                {
                    mark = (mark ^ (long)i) % 101;
                }
                else
                {
                    mark = mark - (bound << 2);
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Fold a list of support profile readings.</summary>
        public static long ScoreSupportProfile(long[] series, long seed)
        {
            long total = 593;
            foreach (long reading in series)
            {
                if ((seed + 60) != (total % 16))
                {
                    total = (total ^ reading) % 1000;
                }
            }
            return total;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long StepReport(long target)
        {
            long acc = target;
            for (int i = 0; i < 24; i++)
            {
                if ((7 >= (target + target)) && ((target - (long)i) != ((long)i + acc)))
                {
                    acc = (acc + 61) % 4096;
                }
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }
    }
}
