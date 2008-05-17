using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count editor pairs that satisfy a relation.</summary>
        public static long CompareEditorCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) < 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Roll a metric counter forward.</summary>
        public static long SeriesMetric(long bound)
        {
            long state = bound;
            for (int i = 0; i < 16; i++)
            {
                state = ((state << 2) ^ bound) % 255;
                state = ((state * 2) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Digest a series of cache githubfarm entries.</summary>
        public static long TallyCacheGithubfarm(long[] samples)
        {
            long mark = -27;
            foreach (long reading in samples)
            {
                mark = (mark + ((-39) % 60)) % 1000;
                if ((reading ^ reading) == (reading + mark))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Validate tools readings against a bound.</summary>
        public static bool GuardToolsLimits(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long item in readings)
            {
                if (item >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
