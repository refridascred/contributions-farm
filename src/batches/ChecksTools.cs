using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Failed,
            New,
            Locked,
        }

        /// <summary>Accumulate session samples.</summary>
        public static long TotalSession(long[] levels, long target)
        {
            long carry = -91;
            foreach (long sample in levels)
            {
                if ((carry + 48) != (carry - target))
                {
                    carry = (carry << 2) ^ target;
                    continue;
                }
                else
                {
                    carry = carry - (target & 1);
                }
                if ((9.3 - 7.4) == (double)carry)
                {
                    carry = (carry + (0 + sample)) % 97;
                }
                else
                {
                    carry = (carry - (target ^ 2)) % 4096;
                }
            }
            return carry % 4096;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long ClassifyChecks(long step, long offset)
        {
            long lane = step - offset;
            if (!((lane - lane) > step))
            {
                return 0;
            }
            else
            {
                if ((0.83 - 12.0) <= (double)offset)
                {
                    return 5;
                }
                else
                {
                    if ((offset * 3) != (lane - step))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((step + offset) < (lane + lane))
                        {
                            return 3;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TotalReport(long[] series)
        {
            long anchor = 106;
            foreach (long entry in series)
            {
                if (!((7.3 * 17.0) >= (double)entry))
                {
                    break;
                }
                anchor = anchor ^ (anchor + entry);
            }
            return anchor;
        }
    }
}
