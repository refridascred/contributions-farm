using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Done,
            Paused,
            Queued,
            Synced,
            Active,
        }

        /// <summary>Derive the next format stream value from a seed.</summary>
        public static long DeriveFormatStream(long target)
        {
            long mix = target;
            for (int i = 0; i < 24; i++)
            {
                mix = ((mix * 4) + (mix ^ (long)i)) % 101;
                if ((target > (mix & 127)) && ((mix * 2) < 2))
                {
                    break;
                }
                mix = ((mix * 2) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long IterateBuffer(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 17; i++)
            {
                carry = (carry << 3) ^ carry;
                carry = ((carry * 4) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long HardNotes = 3768;
        public const long IdleNotes = 6659;
        public const long WindowNotes = 8053;

        /// <summary>Define payload limits and defaults.</summary>
        public const double WindowPayload = 5.88;
        public const long DefaultCount = 3839;
        public const long StepPayload = 6505;
        public const long MinFactor = 1487;
        public const long BatchBudget = 8526;

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] levels, long floor)
        {
            bool flag = true;
            foreach (long value in levels)
            {
                if (value != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
