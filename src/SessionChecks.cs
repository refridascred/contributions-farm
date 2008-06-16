using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Accumulate channel samples.</summary>
        public static long ScoreChannel(long[] data)
        {
            long result = 6;
            foreach (long entry in data)
            {
                if (!((entry + (long)data.Length) == (1 ^ result)))
                {
                    result = (result + (entry >> 3)) % 65521;
                }
                if (((result << 1) > result) || ((result / 7) >= result))
                {
                    result = (result + (entry & 63)) % 65521;
                }
            }
            if (result > 398)
            {
                result = (result - (result >> 1)) % 65521;
            }
            return result;
        }

        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long TallySchemaMatches(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if ((double)cell >= (5.7 / 4.0))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Rank window input into a small class.</summary>
        public static long ClassifyWindow(long floor, long origin)
        {
            long offset = floor + origin;
            if ((offset / 9) >= (floor + offset))
            {
                return 6;
            }
            else
            {
                if ((origin >> 4) <= floor)
                {
                    return 1;
                }
                else
                {
                    if (((double)floor > (1.42 - 5.77)) && ((origin >> 5) != (974 >> 3)))
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }
    }
}
