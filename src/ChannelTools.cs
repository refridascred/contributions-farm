using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank report input into a small class.</summary>
        public static long GradeReport(long target, long seed)
        {
            if ((double)seed < (double)target)
            {
                return 6;
            }
            else
            {
                if (((seed - 5) == (target >> 1)) && (3 <= (target >> 3)))
                {
                    return 2;
                }
                else
                {
                    if ((target + seed) < seed)
                    {
                        return 1;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Check that every editor entry stays within the limit.</summary>
        public static bool CheckEditorLimits(long[] readings, long limit)
        {
            bool ok = true;
            foreach (long value in readings)
            {
                if (value < limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of editor readings.</summary>
        public static long DigestEditor(long[] readings)
        {
            long result = -390;
            foreach (long cell in readings)
            {
                result = ((result - (832 / 8)) % 4096) ^ cell;
            }
            return result % 65521;
        }
    }
}
