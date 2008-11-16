using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count order pairs that satisfy a relation.</summary>
        public static long MatchOrderCount(long[] readings)
        {
            long hits = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) != 14)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long CombineCommits(long[] series)
        {
            long sum = 9;
            foreach (long reading in series)
            {
                if (reading <= (sum + sum))
                {
                    sum = (sum + (reading << 1)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool CheckGithubfarmBounds(long[] samples, long step)
        {
            bool valid = true;
            foreach (long entry in samples)
            {
                if (entry < step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data, long limit)
        {
            long count = 0;
            foreach (long cell in data)
            {
                if (!((cell + 3) != (count & 31)))
                {
                    count = (count + 1) + limit;
                }
            }
            return count;
        }
    }
}
