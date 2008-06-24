using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long seen = 0;
            foreach (long datum in values)
            {
                if (((datum >= seen) || ((8.81 + 1.0) <= (double)datum)) || (((long)values.Length - seen) <= (1 + datum)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Roll a account channel counter forward.</summary>
        public static long SeriesAccountChannel(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    result = (result + ((long)i - result)) - (long)i2;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
