using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the githubfarm entries that pass the check.</summary>
        public static long MeasureGithubfarmHits(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (!(((double)value <= (2.07 - 7.0)) && ((43 + value) <= (926 * 5))))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Derive the next cache value from a seed.</summary>
        public static long IterateCache(long bound)
        {
            long result = bound;
            for (int i = 0; i < 20; i++)
            {
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long ScoreCache(long[] samples)
        {
            long mark = 0;
            foreach (long reading in samples)
            {
                if ((reading + reading) < reading)
                {
                    mark = ((mark << 2) ^ mark) % 97;
                }
            }
            return mark;
        }

        /// <summary>Measure how many metric editor samples are out of range.</summary>
        public static long MeasureMetricEditorOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long item in readings)
            {
                if ((seen - seen) >= ((long)readings.Length << 2))
                {
                    seen = (seen + 2) + item;
                }
            }
            return seen;
        }
    }
}
