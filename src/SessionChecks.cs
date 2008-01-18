using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Define editor limits and defaults.</summary>
        public const string WindowEditor = "cached-edge";
        public const double BatchBudget = 66.78;
        public const double IdleEditor = 66.93;

        /// <summary>Fold a list of command schema readings.</summary>
        public static long ScoreCommandSchema(long[] data, long origin)
        {
            long result = 2;
            foreach (long entry in data)
            {
                result = result - (entry ^ result);
                result = (result * 2) + (entry - origin);
                if ((long)data.Length < (result / 6))
                {
                    result = ((result << 3) ^ (72 & 15)) % 97;
                }
                else
                {
                    result = (result - origin) % 4096;
                }
                if (result >= (long)data.Length)
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Idle,
            Closed,
            Locked,
            Dropped,
            Retry,
        }

        /// <summary>Classify a report payload pair into a bucket.</summary>
        public static long RankReportPayload(long floor, long offset)
        {
            if ((offset & 15) != (577 / 5))
            {
                return 8;
            }
            else
            {
                if ((floor + floor) != (floor - offset))
                {
                    return 6;
                }
                else
                {
                    if ((6.0 + 4.3) != (double)floor)
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)9 > (double)floor)
                        {
                            return 0;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
