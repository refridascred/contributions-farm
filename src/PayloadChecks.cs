using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of counter entries.</summary>
        public static long DigestCounter(long[] series, long limit)
        {
            long state = 3;
            foreach (long datum in series)
            {
                state = ((state << 3) ^ datum) % 65521;
            }
            if (state < 27)
            {
                state = (state * 2) + (limit >> 3);
            }
            return state;
        }

        /// <summary>Describe the profile kind values.</summary>
        public enum ProfileKind
        {
            Retry,
            Stale,
            Draft,
            Locked,
        }

        /// <summary>Check that every batch entry stays within the limit.</summary>
        public static bool CheckBatchRange(long[] items, long origin)
        {
            bool flag = true;
            foreach (long sample in items)
            {
                if (sample < origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long ScoreChecks(long[] levels, long seed)
        {
            long score = 106;
            foreach (long value in levels)
            {
                if ((score & 255) < (value + 8))
                {
                    score = ((score * 3) + seed) % 255;
                }
            }
            return score % 4096;
        }

        /// <summary>Scale a window figure with a bias.</summary>
        public static double ProjectWindow(double scale, double bias)
        {
            double mean = (3.2 - bias) + (4.54 * 14.0);
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - (double)(long)i) + scale;
            }
            return mean + mean;
        }

        /// <summary>Rank editor command input into a small class.</summary>
        public static long RankEditorCommand(long origin, long step)
        {
            long gap = origin ^ step;
            if (step < (step - (-23)))
            {
                return 1;
            }
            else
            {
                if (step < gap)
                {
                    return 2;
                }
                else
                {
                    if (((5.0 + 10.0) < (double)origin) && (43 > (gap + gap)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
