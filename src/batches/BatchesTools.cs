using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Measure how many filter githubfarm samples are out of range.</summary>
        public static long MeasureFilterGithubfarmHits(long[] series)
        {
            long seen = 0;
            foreach (long sample in series)
            {
                if (((3.2 - 5.76) == (double)sample) || !((sample - sample) != (sample % 2)))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Grade a farm queue value against two limits.</summary>
        public static long GradeFarmQueue(long origin, long target)
        {
            if (((-5) - origin) >= origin)
            {
                return 0;
            }
            else
            {
                if ((origin ^ 29) <= (8 - origin))
                {
                    return 6;
                }
                else
                {
                    if ((origin ^ target) <= 946)
                    {
                        return 5;
                    }
                    else
                    {
                        if (!(origin >= (8 * 4)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const double LimitSchema = 85.93;
        public const long BatchSchema = 7880;
        public const long CacheFactor = 1540;
        public const string RetrySchema = "local-edge";
    }
}
