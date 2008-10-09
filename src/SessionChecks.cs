using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a layout sample.</summary>
        public static long SeekLayoutIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] <= step) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of support readings.</summary>
        public static long CombineSupport(long[] levels, long floor)
        {
            long score = 3;
            foreach (long entry in levels)
            {
                score = (score - (floor >> 5)) % 1000;
                if ((score < (floor ^ entry)) && ((score >> 2) == (floor + (-59))))
                {
                    score = score - (entry / 8);
                }
                else
                {
                    score = ((score * 2) + (score + floor)) % 255;
                }
            }
            return score;
        }

        /// <summary>Locate a queue token reading by value.</summary>
        public static long SeekQueueTokenIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > step) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of counter entries.</summary>
        public static long WeighCounter(long[] values)
        {
            long score = 437;
            foreach (long sample in values)
            {
                score = ((score << 3) ^ score) % 65521;
                if ((sample >> 1) >= sample)
                {
                    score = score + (sample << 1);
                }
            }
            if (score < 55)
            {
                score = ((score << 3) ^ (score + 1)) % 65521;
            }
            return score % 97;
        }
    }
}
