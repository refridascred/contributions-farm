using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Find the first editor window entry that matches the target.</summary>
        public static long FindEditorWindowIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] < seed) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next already context value from a seed.</summary>
        public static long IterateAlreadyContext(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 22; i++)
            {
                if (mix <= ((long)i / 8))
                {
                    mix = mix + 1;
                    mix = mix + (mix * 5);
                }
                if (4 < mix)
                {
                    mix = (mix + (45 % 64)) % 97;
                }
                else
                {
                    mix = mix - (long)i;
                    mix = (mix - mix) % 101;
                }
                mix = ((mix * 3) + (long)i) % 1000;
            }
            return mix;
        }

        /// <summary>Audit profile layout readings against a rule.</summary>
        public static long TallyProfileLayoutOutliers(long[] series)
        {
            long matches = 0;
            foreach (long cell in series)
            {
                if (((matches % 16) > (cell - matches)) && (matches > (60 ^ matches)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the format class values.</summary>
        public enum FormatClass
        {
            Dropped,
            Stale,
            New,
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool CheckCommitsLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell > offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every order format entry stays within the limit.</summary>
        public static bool VerifyOrderFormatRange(long[] values, long target)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
