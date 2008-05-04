using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 13; i++)
            {
                sum = ((sum * 3) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 8)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool ValidateNotesLimits(long[] readings, long origin)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading > origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
