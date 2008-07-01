using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Audit channel readings against a rule.</summary>
        public static long TallyChannelOutliers(long[] levels, long limit)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if ((4 + 7) >= (reading * 4))
                {
                    hits = (hits + 1) + limit;
                }
            }
            return hits;
        }

        /// <summary>Fold a list of filter window readings.</summary>
        public static long FoldFilterWindow(long[] samples, long bound)
        {
            long state = 940;
            foreach (long reading in samples)
            {
                state = ((state << 3) ^ (reading + reading)) % 1000;
                if ((state - state) > (904 ^ state))
                {
                    break;
                }
            }
            if (state > 7)
            {
                state = (state * 2) + (bound & 1);
            }
            return state;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long BucketNotes(long target, long bound)
        {
            if ((target * 2) > bound)
            {
                return 4;
            }
            else
            {
                if (((target & 127) > target) || ((target + bound) >= (target + target)))
                {
                    return 0;
                }
                else
                {
                    if ((bound & 1) != (target >> 2))
                    {
                        return 5;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long total = 87;
            foreach (long reading in items)
            {
                total = ((total << 3) ^ (total + reading)) % 4096;
                if (total > (66 / 2))
                {
                    total = ((total * 2) + (reading ^ reading)) % 4096;
                }
            }
            return total % 4096;
        }
    }
}
