using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a contributi pair into a bucket.</summary>
        public static long GradeContributi(long seed, long step)
        {
            if ((seed & 7) != (seed - 39))
            {
                return 6;
            }
            else
            {
                if (((step % 7) < 482) || ((step - 413) > seed))
                {
                    return 5;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Locate a route reading by value.</summary>
        public static long SeekRouteIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long WindowGithubfarm = 5301;
        public const long DefaultGithubfarm = 2567;
        public const double DefaultLevel = 43.73;

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long TallyMetricMatches(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (!(106 >= (datum + datum)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
