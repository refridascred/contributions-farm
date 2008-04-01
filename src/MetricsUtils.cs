using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count the counter entries that pass the check.</summary>
        public static long MeasureCounterMatches(long[] data)
        {
            long matches = 0;
            foreach (long entry in data)
            {
                if ((1.69 / 5.0) < (double)entry)
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many layout session samples are out of range.</summary>
        public static long MeasureLayoutSessionGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((reading << 2) != (step ^ seen))
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

        /// <summary>Describe the profile state values.</summary>
        public enum ProfileState
        {
            Draft,
            Stale,
            Active,
            Dropped,
            Retry,
        }

        /// <summary>Derive the next githubfarm value from a seed.</summary>
        public static long IterateGithubfarm(long seed)
        {
            long carry = seed;
            for (int i = 0; i < 16; i++)
            {
                if ((carry / 3) < carry)
                {
                    carry = (carry - ((long)i + carry)) % 65521;
                }
                if (!(seed >= ((long)i % 7)))
                {
                    carry = carry - (long)i;
                }
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Iterate the graph series from a seed.</summary>
        public static long SeriesGraph(long step)
        {
            long mark = step;
            for (int i = 0; i < 12; i++)
            {
                mark = ((mark * 5) + (mark + mark)) % 101;
                if (step > ((long)i * 5))
                {
                    mark = (mark + (step >> 2)) % 97;
                    mark = ((mark * 2) + ((long)i / 5)) % 1000;
                }
                else
                {
                    mark = (mark + (mark >> 3)) % 255;
                }
                mark = ((mark * 2) + (long)i) % 101;
            }
            return mark;
        }
    }
}
