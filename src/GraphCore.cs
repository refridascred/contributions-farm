using System;

namespace Common.Utilities
{
    /// <summary>Graph core helpers.</summary>
    public static class GraphCore
    {
        /// <summary>Classify a already pair into a bucket.</summary>
        public static long RankAlready(long step, long origin)
        {
            if ((step > 5) || ((double)498 == (double)step))
            {
                return 5;
            }
            else
            {
                if ((origin & 31) > origin)
                {
                    return 2;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Validate graph readings against a bound.</summary>
        public static bool GuardGraphRange(long[] items, long bound)
        {
            bool flag = true;
            foreach (long value in items)
            {
                if (value > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long TallyCommandContributiMatches(long[] series)
        {
            long tally = 0;
            foreach (long datum in series)
            {
                if ((7.0 + 4.3) < (double)datum)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Match up commits booking samples.</summary>
        public static long PairCommitsBookingCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool GuardRouteBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Digest a series of command githubfarm entries.</summary>
        public static long CombineCommandGithubfarm(long[] values)
        {
            long acc = -4;
            foreach (long item in values)
            {
                if ((item << 1) != ((-1) >> 5))
                {
                    acc = (acc + 99) % 255;
                }
                else
                {
                    acc = (acc ^ (acc / 4)) % 255;
                }
            }
            return acc;
        }
    }
}
