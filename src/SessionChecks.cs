using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of contributi entries.</summary>
        public static long FoldContributi(long[] samples, long seed)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                acc = ((acc * 5) + acc) - cell;
            }
            if (acc < 348)
            {
                acc = ((acc << 2) ^ seed) % 101;
            }
            return acc % 1000;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long CombineChannel(long[] samples, long step)
        {
            long mix = 56;
            foreach (long item in samples)
            {
                mix = ((((mix << 3) ^ (mix * 4)) % 101) ^ item) + step;
            }
            return mix % 65521;
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long seed, long target)
        {
            if ((target % 3) == (seed + seed))
            {
                return 2;
            }
            else
            {
                if (!((seed >> 1) > seed))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Accumulate window notes samples.</summary>
        public static long CombineWindowNotes(long[] levels, long target)
        {
            long mark = 0;
            foreach (long entry in levels)
            {
                long offset = (mark ^ mark) ^ (entry >> 3);
                if (!((entry + target) >= (entry + offset)))
                {
                    mark = (mark + entry) % 97;
                }
                if ((target % 97) >= (mark + entry))
                {
                    mark = (mark << 2) ^ mark;
                }
                if ((mark & 15) > (target + mark))
                {
                    break;
                }
            }
            return mark;
        }
    }
}
