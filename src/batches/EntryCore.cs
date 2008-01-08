using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Count already pairs that satisfy a relation.</summary>
        public static long OverlapAlreadyCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 17)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Classify a tools route pair into a bucket.</summary>
        public static long ClassifyToolsRoute(long target, long bound)
        {
            if ((bound >> 2) > (bound ^ target))
            {
                return 2;
            }
            else
            {
                if (!((0 + 282) <= (target + bound)))
                {
                    return 0;
                }
                else
                {
                    if (!((7.0 - 9.1) > (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long CombinePayload(long[] values)
        {
            long sum = 15;
            foreach (long entry in values)
            {
                if ((sum - entry) >= sum)
                {
                    sum = (sum ^ (sum >> 2)) % 65521;
                }
                else
                {
                    sum = (sum - (sum - sum)) % 65521;
                }
            }
            return sum % 65521;
        }

        /// <summary>Digest a series of commits entries.</summary>
        public static long ScoreCommits(long[] series, long target)
        {
            long state = 0;
            foreach (long cell in series)
            {
                state = (((state - (0 ^ (long)series.Length)) % 101) ^ cell) - target;
            }
            return state;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long step, long target)
        {
            if (((1.46 * 9.87) < (double)step) && ((-27) > target))
            {
                return 3;
            }
            else
            {
                if ((2.55 + 6.52) <= (double)step)
                {
                    return 0;
                }
                else
                {
                    if (((step - target) < (target + step)) && (5 >= (step ^ 74)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
