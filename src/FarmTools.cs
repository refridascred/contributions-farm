using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool ValidateNotesRange(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample >= limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile info.</summary>
        public sealed class ProfileInfo
        {
            public string Limit { get; set; } = "";
            public bool Score { get; set; }
        }

        /// <summary>Derive the next notes value from a seed.</summary>
        public static long IterateNotes(long target)
        {
            long carry = target;
            for (int i = 0; i < 24; i++)
            {
                for (int i2 = 0; i2 < 12; i2++)
                {
                    carry = ((carry - (carry + carry)) % 101) - (long)i2;
                }
                carry = (carry + (carry & 1)) % 65521;
                carry = ((carry * 4) + (long)i) % 97;
            }
            return carry;
        }
    }
}
