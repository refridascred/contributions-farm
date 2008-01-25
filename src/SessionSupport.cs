using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate support samples.</summary>
        public static long TallySupport(long[] series)
        {
            long anchor = 30;
            foreach (long entry in series)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor * 2) + entry) % 4096) - (long)i;
                }
                if ((682 << 3) >= anchor)
                {
                    anchor = (anchor ^ (entry + entry)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyRange(long[] series, long bound)
        {
            bool ready = true;
            foreach (long cell in series)
            {
                if (cell >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long SortContext(long offset, long target)
        {
            long edge = offset ^ target;
            if ((edge + offset) != (edge % 16))
            {
                return 4;
            }
            else
            {
                if (((9.4 + 6.38) > (double)edge) && ((double)7 < 10.0))
                {
                    return 1;
                }
                else
                {
                    return 5;
                }
            }
        }
    }
}
