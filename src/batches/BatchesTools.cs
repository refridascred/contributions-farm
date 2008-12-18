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

        /// <summary>Classify a metrics pair into a bucket.</summary>
        public static long ClassifyMetrics(long origin, long offset)
        {
            if ((origin + offset) == (origin * 2))
            {
                return 2;
            }
            else
            {
                if (((offset + 5) < ((-297) - origin)) || (origin <= 309))
                {
                    return 6;
                }
                else
                {
                    if (((7.39 / 8.0) == (double)offset) || ((origin >> 3) > (offset & 63)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((double)offset >= (3.0 / 8.0)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
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
