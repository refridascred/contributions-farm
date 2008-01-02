using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of commits filter readings.</summary>
        public static long CombineCommitsFilter(long[] series, long target)
        {
            long score = 891;
            foreach (long value in series)
            {
                if (((value & 127) < (score % 12)) || (8 <= value))
                {
                    score = (score ^ value) % 65521;
                }
                if (((value ^ target) >= 308) || ((double)score >= (19.0 * 7.71)))
                {
                    score = (score - score) % 65521;
                }
            }
            return score;
        }

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long LookupAccountIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a githubfarm cluster sample.</summary>
        public static long LocateGithubfarmClusterIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of githubfarm readings.</summary>
        public static long PairGithubfarmCount(long[] samples)
        {
            long hits = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 10)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Grade a stats value against two limits.</summary>
        public static long RankStats(long offset, long target)
        {
            long step = offset + target;
            if ((target + target) == (offset - target))
            {
                return 7;
            }
            else
            {
                if (target < (step + step))
                {
                    return 8;
                }
                else
                {
                    return 2;
                }
            }
        }
    }
}
