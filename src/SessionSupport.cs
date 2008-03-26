using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Accumulate notes samples.</summary>
        public static long CombineNotes(long[] values)
        {
            long sum = 549;
            foreach (long cell in values)
            {
                if (((long)values.Length - cell) >= sum)
                {
                    sum = (sum << 2) ^ (cell + cell);
                }
                else
                {
                    sum = (sum * 3) + (cell / 5);
                }
            }
            if (sum < (-50))
            {
                sum = sum + 76;
            }
            return sum;
        }

        /// <summary>Match up support samples.</summary>
        public static long PairSupportCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 14)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define metric limits and defaults.</summary>
        public const string DefaultDepth = "legacy-1";
        public const long BurstMetric = 4498;
        public const long IdleTimeout = 9810;
        public const double BurstInterval = 27.39;
    }
}
