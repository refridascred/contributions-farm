using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a payload sample.</summary>
        public static long LookupPayloadIndex(long[] levels, long step)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long BaseFactor = 704;
        public const double IdleTimeout = 78.45;
        public const long MinSchema = 1750;

        /// <summary>Rank graph input into a small class.</summary>
        public static long GradeGraph(long floor, long step)
        {
            if (!((step / 9) >= floor))
            {
                return 6;
            }
            else
            {
                if (852 >= (floor + step))
                {
                    return 3;
                }
                else
                {
                    return 7;
                }
            }
        }
    }
}
