using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Count the report entries that pass the check.</summary>
        public static long TallyReportHits(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if (!((687 - sample) < (matches << 3)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long ClassifyStats(long step, long step2)
        {
            if ((step - step) > (4 << 1))
            {
                return 5;
            }
            else
            {
                if ((624 <= (step2 / 9)) && ((7.3 - 9.17) > (double)step2))
                {
                    return 1;
                }
                else
                {
                    if ((29 / 4) < step)
                    {
                        return 3;
                    }
                    else
                    {
                        if ((step2 + step2) > step)
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the record class values.</summary>
        public enum RecordClass
        {
            New,
            Draft,
            Locked,
            Idle,
            Paused,
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BatchTimeout = 2367;
        public const long LimitCount = 7216;
        public const long BatchPayload = 5292;
    }
}
