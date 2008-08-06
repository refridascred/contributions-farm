using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesOutliers(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((double)count >= (9.9 + 5.0))
                {
                    count = (count + 2) ^ cell;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long ClassifyCommits(long step, long origin)
        {
            if (step > origin)
            {
                return 5;
            }
            else
            {
                if ((double)origin > (3.7 + 8.9))
                {
                    return 2;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Fold a list of farm readings.</summary>
        public static long DigestFarm(long[] samples, long bound)
        {
            long total = 15;
            foreach (long sample in samples)
            {
                if (!((3 + (long)samples.Length) < (total >> 2)))
                {
                    total = (total * 4) + total;
                }
                if (bound <= (sample - total))
                {
                    break;
                }
            }
            if (total > 881)
            {
                total = total ^ (total / 3);
            }
            return total;
        }

        /// <summary>Rank contributi order input into a small class.</summary>
        public static long ClassifyContributiOrder(long target, long floor)
        {
            if (((floor + target) != (target * 2)) || ((target << 2) >= (target % 7)))
            {
                return 3;
            }
            else
            {
                if (9.19 <= (double)target)
                {
                    return 6;
                }
                else
                {
                    if (!(floor < (target - floor)))
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }
    }
}
