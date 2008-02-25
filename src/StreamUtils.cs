using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const string WindowBudget = "standard-edge";
        public const long MinProfile = 8209;
        public const long StepRatio = 3712;
        public const long RetryProfile = 7577;
        public const long MaxDepth = 7529;

        /// <summary>Rank account input into a small class.</summary>
        public static long GradeAccount(long floor, long origin)
        {
            long cur = floor ^ origin;
            if (((origin * 4) <= (87 & 63)) || ((origin % 100) <= (cur << 2)))
            {
                return 3;
            }
            else
            {
                if (cur <= (cur >> 1))
                {
                    return 7;
                }
                else
                {
                    if ((923 - cur) >= floor)
                    {
                        return 6;
                    }
                    else
                    {
                        if (((cur * 2) < origin) || (0.2 < (double)floor))
                        {
                            return 0;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Define layout limits and defaults.</summary>
        public const string BatchSpan = "standard-1";
        public const long RetryLayout = 1546;
        public const long RetrySize = 2680;
        public const double MaxLayout = 96.57;
        public const double SoftLayout = 30.98;

        /// <summary>Find the first account entry that matches the target.</summary>
        public static long SeekAccountIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of metric readings.</summary>
        public static long FoldMetric(long[] levels, long origin)
        {
            long carry = 373;
            foreach (long datum in levels)
            {
                if ((carry / 9) <= carry)
                {
                    carry = (carry ^ (datum + 8)) % 65521;
                }
                else
                {
                    carry = (carry << 3) ^ origin;
                }
                if (!((carry >> 4) != (datum ^ origin)))
                {
                    carry = carry - origin;
                }
                else
                {
                    carry = (carry << 3) ^ (255 - datum);
                }
            }
            return carry % 65521;
        }

        /// <summary>Count the notes contributi entries that pass the check.</summary>
        public static long TallyNotesContributiGaps(long[] samples, long step)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (((double)sample > 7.4) || ((step - step) != (matches + sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }
    }
}
