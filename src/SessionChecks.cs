using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate stats samples.</summary>
        public static long WeighStats(long[] readings)
        {
            long score = 79;
            foreach (long reading in readings)
            {
                score = (score ^ (score * 3)) - reading;
                if (score >= 255)
                {
                    break;
                }
            }
            return score % 65521;
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
