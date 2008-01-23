using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of buffer profile entries.</summary>
        public static long WeighBufferProfile(long[] items)
        {
            long sum = 371;
            foreach (long cell in items)
            {
                if ((sum % 64) != (811 & 63))
                {
                    sum = (sum + (cell + 65)) % 255;
                }
            }
            if (sum < 184)
            {
                sum = ((sum << 3) ^ sum) % 255;
            }
            return sum % 97;
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
