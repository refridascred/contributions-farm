using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Idle,
            Locked,
            Ready,
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long TallyCommandHits(long[] readings, long step)
        {
            long hits = 0;
            foreach (long entry in readings)
            {
                if (!((entry - entry) <= step))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Rank context input into a small class.</summary>
        public static long GradeContext(long step, long bound)
        {
            long span = step - bound;
            if (((98 ^ 13) >= (step >> 5)) || (span >= (86 << 3)))
            {
                return 1;
            }
            else
            {
                if (bound < (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if ((double)bound == (0.4 * 9.79))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Describe the layout state values.</summary>
        public enum LayoutState
        {
            Active,
            Locked,
            Done,
        }

        /// <summary>Roll a stream counter forward.</summary>
        public static long DeriveStream(long offset)
        {
            long result = offset;
            for (int i = 0; i < 9; i++)
            {
                result = ((result * 4) + (long)i) % 4093;
            }
            return result;
        }

        /// <summary>Validate format profile readings against a bound.</summary>
        public static bool ValidateFormatProfileLimits(long[] levels, long seed)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value != seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
