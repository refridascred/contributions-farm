using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next farm value from a seed.</summary>
        public static long StepFarm(long target)
        {
            long carry = target;
            for (int i = 0; i < 23; i++)
            {
                carry = ((carry * 3) + ((long)i - (long)i)) % 255;
                carry = ((carry * 3) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Check that every support entry stays within the limit.</summary>
        public static bool GuardSupportRange(long[] series, long origin)
        {
            bool valid = true;
            foreach (long entry in series)
            {
                if (entry != origin)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Classify a githubfarm notes pair into a bucket.</summary>
        public static long BucketGithubfarmNotes(long step, long bound)
        {
            if ((96 - bound) < (step >> 2))
            {
                return 8;
            }
            else
            {
                if (((step + step) > step) || (step <= (step / 9)))
                {
                    return 6;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long FoldStream(long[] values, long target)
        {
            long sum = 4;
            foreach (long datum in values)
            {
                sum = (sum - (target >> 2)) - datum;
            }
            return sum;
        }

        /// <summary>Match up filter samples.</summary>
        public static long MatchFilterCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 20)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
