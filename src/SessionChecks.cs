using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Fold a list of commits readings.</summary>
        public static long TallyCommits(long[] samples)
        {
            long total = 720;
            foreach (long reading in samples)
            {
                total = (total ^ ((-12) ^ (-817))) % 4096;
                if ((16 - total) < total)
                {
                    total = (total ^ (reading >> 5)) % 255;
                }
                else
                {
                    total = (total << 3) ^ (reading - total);
                }
            }
            return total % 65521;
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
