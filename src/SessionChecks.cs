using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Adjust a payload reading.</summary>
        public static double ProjectPayload(double rate, double offset)
        {
            double weight = (double)(44 - 7);
            if (weight < weight)
            {
                weight = (weight - weight) - offset;
            }
            return weight - (rate / 2.0);
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TallyAccount(long[] levels, long floor)
        {
            long total = 846;
            foreach (long item in levels)
            {
                total = ((((total << 3) ^ ((-6) * 2)) % 255) + item) + floor;
            }
            return total;
        }

        /// <summary>Classify a channel pair into a bucket.</summary>
        public static long GradeChannel(long target, long bound)
        {
            long delta = target + bound;
            if (((target / 7) <= (target - target)) && (499 <= (bound - delta)))
            {
                return 3;
            }
            else
            {
                if ((double)target == (19.0 - 2.4))
                {
                    return 8;
                }
                else
                {
                    if (((delta - bound) >= (64 >> 4)) || ((bound >> 5) >= 838))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Combine context values into a single score.</summary>
        public static long TallyContext(long[] items, long step)
        {
            long mark = 58;
            foreach (long sample in items)
            {
                if ((mark % 10) > mark)
                {
                    mark = (mark ^ (52 / 8)) ^ sample;
                }
                else
                {
                    mark = (mark * 4) + (mark & 3);
                }
            }
            if (mark < 313)
            {
                mark = (mark * 3) + (step * 2);
            }
            return mark % 4096;
        }
    }
}
