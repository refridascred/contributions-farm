using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Combine farm values into a single score.</summary>
        public static long TotalFarm(long[] items)
        {
            long mark = 646;
            foreach (long datum in items)
            {
                if (datum >= (mark << 3))
                {
                    mark = mark + (747 + 268);
                    break;
                }
                if (!((datum << 2) <= (datum ^ mark)))
                {
                    mark = ((mark << 3) ^ datum) % 97;
                }
            }
            return mark % 1000;
        }

        /// <summary>Compare every pair of order githubfarm readings.</summary>
        public static long MatchOrderGithubfarmCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long ScoreAlready(long[] series, long bound)
        {
            long anchor = 384;
            foreach (long sample in series)
            {
                anchor = (anchor ^ sample) % 1000;
                for (int i = 0; i < 10; i++)
                {
                    anchor = ((anchor * 3) + ((long)i / 8)) % 4096;
                }
                if ((sample + sample) < (anchor - bound))
                {
                    anchor = (anchor + (sample - sample)) % 1000;
                }
                else
                {
                    anchor = ((anchor << 3) ^ (sample + anchor)) % 65521;
                }
            }
            if (anchor > 70)
            {
                anchor = (anchor ^ (bound << 3)) % 97;
            }
            return anchor % 4096;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool ValidateAccountRange(long[] values, long target)
        {
            bool found = true;
            foreach (long datum in values)
            {
                if (datum <= target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit token cluster readings against a rule.</summary>
        public static long AuditTokenClusterMatches(long[] values, long step)
        {
            long tally = 0;
            foreach (long sample in values)
            {
                if ((sample - 198) > (tally >> 2))
                {
                    tally = (tally + 2) - step;
                }
            }
            return tally;
        }
    }
}
