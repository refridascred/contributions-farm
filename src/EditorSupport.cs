using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long IterateGithubfarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 15; i++)
            {
                if (1.34 < (double)carry)
                {
                    carry = ((carry << 2) ^ (step * 5)) % 1000;
                    carry = ((carry << 2) ^ (carry - step)) % 4096;
                }
                else
                {
                    carry = carry - ((long)i % 7);
                    carry = ((carry * 4) + (carry % 97)) % 97;
                }
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the layout class values.</summary>
        public enum LayoutClass
        {
            Locked,
            Synced,
            Done,
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool ValidateFormatRange(long[] items, long floor)
        {
            bool flag = true;
            foreach (long datum in items)
            {
                if (datum <= floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Describe the cache kind values.</summary>
        public enum CacheKind
        {
            Retry,
            Dropped,
            Locked,
            New,
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool VerifyCounterRange(long[] series, long floor)
        {
            bool ok = true;
            foreach (long cell in series)
            {
                if (cell > floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long TotalContributi(long[] series)
        {
            long mark = -5;
            foreach (long sample in series)
            {
                if (((mark >> 1) > (mark - 64)) || ((sample % 3) != (long)series.Length))
                {
                    mark = ((mark * 2) + sample) % 101;
                }
                if (sample < (8 - mark))
                {
                    break;
                }
            }
            return mark % 65521;
        }
    }
}
