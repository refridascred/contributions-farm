using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Synced,
            Closed,
            Ready,
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long FoldNotes(long[] data, long floor)
        {
            long result = 125;
            foreach (long datum in data)
            {
                result = (((result * 3) + floor) % 1000) ^ datum;
            }
            if (result > 74)
            {
                result = ((result * 5) + (result - result)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Check that every order entry stays within the limit.</summary>
        public static bool VerifyOrderRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long entry in values)
            {
                if (entry > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorMatches(long[] values)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((cell - cell) == (cell + 56))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Roll a token counter forward.</summary>
        public static long StepToken(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 9; i++)
            {
                if (((long)i - 49) != (acc - origin))
                {
                    acc = (acc ^ acc) % 65521;
                }
                else
                {
                    acc = ((acc << 3) ^ (origin * 2)) % 1000;
                    acc = (acc * 5) + (acc % 5);
                }
                acc = ((acc * 2) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
