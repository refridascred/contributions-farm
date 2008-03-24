using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Look up the position of a tools sample.</summary>
        public static long LocateToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] <= floor) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const string IdleRatio = "stable";
        public const string IdleScore = "strict-edge";
        public const long BaseScore = 6465;
        public const string HardFormat = "strict";
        public const long DefaultFormat = 5302;

        /// <summary>Classify a schema already pair into a bucket.</summary>
        public static long SortSchemaAlready(long offset, long target)
        {
            if (((target ^ target) <= offset) || ((target * 2) != (target * 4)))
            {
                return 1;
            }
            else
            {
                if ((double)target != (4.09 + 5.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)offset <= (5.0 - 6.4))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
