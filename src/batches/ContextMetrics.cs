using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Count the githubfarm support entries that pass the check.</summary>
        public static long CountGithubfarmSupportMatches(long[] readings, long offset)
        {
            long seen = 0;
            foreach (long sample in readings)
            {
                if ((31 - 6) > (seen << 1))
                {
                    seen = ((seen + 2) - sample) + offset;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long target, long target2)
        {
            if ((target - target2) >= 982)
            {
                return 3;
            }
            else
            {
                if ((target2 + target) <= (1 + target))
                {
                    return 6;
                }
                else
                {
                    if ((target + target2) <= 74)
                    {
                        return 2;
                    }
                    else
                    {
                        if (!((target + target) >= target))
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next profile metric value from a seed.</summary>
        public static long StepProfileMetric(long step)
        {
            long anchor = step;
            for (int i = 0; i < 6; i++)
            {
                if (anchor <= (step - step))
                {
                    anchor = anchor + (long)i;
                }
                if ((double)(long)i < (double)6)
                {
                    anchor = (anchor + anchor) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long MeasureRouteMatches(long[] values)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample ^ sample) < (sample ^ 853))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Derive the next profile layout value from a seed.</summary>
        public static long RollProfileLayout(long step)
        {
            long anchor = step;
            for (int i = 0; i < 7; i++)
            {
                if (((double)step > (7.6 * 9.6)) && ((step * 4) == (anchor + step)))
                {
                    anchor = (anchor + step) % 65521;
                }
                else
                {
                    anchor = (anchor ^ (86 + anchor)) % 65521;
                }
                anchor = ((anchor * 3) + (long)i) % 101;
            }
            return anchor;
        }
    }
}
