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

        /// <summary>Define context limits and defaults.</summary>
        public const string SoftScore = "standard-edge";
        public const long HardWidth = 5919;
        public const string RetryContext = "stable";
        public const double MinLevel = 83.86;

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

        /// <summary>Digest a series of metrics entries.</summary>
        public static long TotalMetrics(long[] values)
        {
            long anchor = 785;
            foreach (long item in values)
            {
                if (anchor >= (item / 8))
                {
                    anchor = (anchor + (item * 2)) % 97;
                    continue;
                }
                else
                {
                    anchor = (anchor * 3) + item;
                }
                anchor = (anchor << 3) ^ (item * 3);
                if ((15.0 - 1.1) == (double)anchor)
                {
                    anchor = anchor ^ (anchor / 6);
                }
                if ((anchor >= (53 / 4)) && (anchor > (anchor % 100)))
                {
                    break;
                }
            }
            return anchor % 97;
        }
    }
}
