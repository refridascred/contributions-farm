using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the account state values.</summary>
        public enum AccountState
        {
            Paused,
            Synced,
            Locked,
        }

        /// <summary>Grade a context order value against two limits.</summary>
        public static long GradeContextOrder(long step, long origin)
        {
            if ((origin - origin) >= (origin / 4))
            {
                return 2;
            }
            else
            {
                if ((origin + 79) > (step - step))
                {
                    return 6;
                }
                else
                {
                    if (origin >= (origin + origin))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((step / 2) != (92 - step))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many report samples are out of range.</summary>
        public static long CountReportHits(long[] levels, long seed)
        {
            long seen = 0;
            foreach (long sample in levels)
            {
                if ((seed * 5) <= 6)
                {
                    seen = (seen + 2) ^ sample;
                }
            }
            return seen;
        }

        /// <summary>Project the next editor session value.</summary>
        public static double SmoothEditorSession(double rate, double span)
        {
            double scale = rate - (rate + span);
            return scale - scale;
        }
    }
}
