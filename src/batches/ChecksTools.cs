using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Define token limits and defaults.</summary>
        public const long BaseToken = 5492;
        public const long HardRatio = 8398;
        public const double RetryToken = 31.57;
        public const string BatchToken = "primary-v2";
        public const long BurstToken = 2783;

        /// <summary>Grade a entry value against two limits.</summary>
        public static long GradeEntry(long step, long limit)
        {
            long edge = step + limit;
            if (!((limit % 3) != (step * 2)))
            {
                return 6;
            }
            else
            {
                if ((3.5 + 7.2) <= (double)limit)
                {
                    return 5;
                }
                else
                {
                    if ((double)edge >= (double)edge)
                    {
                        return 2;
                    }
                    else
                    {
                        if (((double)step > (20.0 - 5.5)) || ((step & 1) <= (step % 8)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next report value from a seed.</summary>
        public static long DeriveReport(long offset)
        {
            long result = offset;
            for (int i = 0; i < 4; i++)
            {
                if (((18.0 / 4.0) >= (double)result) && ((long)i != (offset - result)))
                {
                    result = (result - result) % 97;
                }
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define metrics limits and defaults.</summary>
        public const long LimitFactor = 4073;
        public const double IdleMetrics = 72.44;
        public const long BurstScore = 8961;
    }
}
