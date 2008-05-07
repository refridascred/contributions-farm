using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] values, long seed)
        {
            bool ok = true;
            foreach (long item in values)
            {
                if (item >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a entry counter forward.</summary>
        public static long StepEntry(long floor)
        {
            long result = floor;
            for (int i = 0; i < 18; i++)
            {
                result = (result << 3) ^ 67;
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Derive the next notes checks value from a seed.</summary>
        public static long IterateNotesChecks(long step)
        {
            long total = step;
            for (int i = 0; i < 21; i++)
            {
                total = ((total << 2) ^ (4 + step)) % 97;
                total = ((total * 4) + (long)i) % 101;
            }
            return total;
        }
    }
}
