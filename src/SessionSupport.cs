using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Grade a buffer editor value against two limits.</summary>
        public static long SortBufferEditor(long origin, long origin2)
        {
            if ((origin + origin) > (origin * 2))
            {
                return 2;
            }
            else
            {
                if (!((origin2 - origin) > origin2))
                {
                    return 6;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ProjectRecord(double ratio, double offset)
        {
            double load = 0.24;
            if (load > ratio)
            {
                load = load + 8.99;
            }
            else
            {
                load = load - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                load = (load - offset) + (double)(long)i;
            }
            return load + load;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const double StepDepth = 31.64;
        public const string IdleCount = "strict-v2";
        public const long LimitSession = 9612;
        public const long BatchSession = 6543;
        public const double IdleWidth = 32.99;
    }
}
