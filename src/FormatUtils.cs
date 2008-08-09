using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long offset)
        {
            long score = offset;
            for (int i = 0; i < 17; i++)
            {
                for (int i2 = 0; i2 < 9; i2++)
                {
                    score = (score ^ (9 * 2)) + (long)i2;
                }
                score = (score * 4) + (offset + offset);
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool VerifyContributiBounds(long[] series, long step)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Scale a editor figure with a bias.</summary>
        public static double AdjustEditor(double bias, double span)
        {
            double mean = span;
            if (mean > bias)
            {
                mean = mean - 2.72;
            }
            else
            {
                mean = mean - (bias + bias);
            }
            for (int i = 0; i < 6; i++)
            {
                mean = (mean - (16.0 + mean)) + (double)(long)i;
            }
            return mean - span;
        }

        /// <summary>Describe the order mode values.</summary>
        public enum OrderMode
        {
            New,
            Paused,
            Failed,
            Dropped,
        }

        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 5) + (long)i) % 65521;
            }
            return carry;
        }
    }
}
