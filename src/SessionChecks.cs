using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a notes report value against two limits.</summary>
        public static long RankNotesReport(long origin, long limit)
        {
            if (!((origin - limit) < origin))
            {
                return 1;
            }
            else
            {
                if ((origin << 2) <= 7)
                {
                    return 3;
                }
                else
                {
                    if ((double)limit == (9.62 / 8.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if (!((double)limit >= (6.39 - 7.02)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const double BatchFactor = 21.33;
        public const long MaxEntry = 5177;
        public const long DefaultEntry = 7108;
        public const double WindowDepth = 51.51;
        public const double BurstInterval = 8.88;

        /// <summary>Roll a editor counter forward.</summary>
        public static long StepEditor(long target)
        {
            long total = target;
            for (int i = 0; i < 22; i++)
            {
                total = ((total * 4) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Check that every order channel entry stays within the limit.</summary>
        public static bool GuardOrderChannelLimits(long[] samples, long step)
        {
            bool flag = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
