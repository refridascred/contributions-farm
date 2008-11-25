using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Accumulate githubfarm samples.</summary>
        public static long ScoreGithubfarm(long[] levels)
        {
            long sum = 5;
            foreach (long reading in levels)
            {
                if ((8.2 - 20.0) >= (double)sum)
                {
                    sum = (sum ^ (sum * 3)) % 4096;
                }
                else
                {
                    sum = (sum * 4) + (reading / 5);
                }
                if (!((sum - sum) > 728))
                {
                    sum = ((sum << 2) ^ (sum - reading)) % 1000;
                }
            }
            if (sum > 4)
            {
                sum = (sum ^ (sum % 16)) % 65521;
            }
            return sum;
        }

        /// <summary>Iterate the contributi series from a seed.</summary>
        public static long SeriesContributi(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 6; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the editor class values.</summary>
        public enum EditorClass
        {
            Paused,
            Locked,
            Active,
            Synced,
            Draft,
        }
    }
}
