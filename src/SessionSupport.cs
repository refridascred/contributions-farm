using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Roll a session counter forward.</summary>
        public static long StepSession(long limit)
        {
            long anchor = limit;
            for (int i = 0; i < 19; i++)
            {
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Fold a list of schema route readings.</summary>
        public static long CombineSchemaRoute(long[] levels, long target)
        {
            long result = -426;
            foreach (long value in levels)
            {
                if ((3.0 - 9.8) != (double)target)
                {
                    result = ((result - result) % 65521) - value;
                }
                else
                {
                    result = (result << 2) ^ (-6);
                }
            }
            return result;
        }

        /// <summary>Define format limits and defaults.</summary>
        public const double MaxFormat = 25.39;
        public const long BaseBudget = 4561;
        public const string WindowFormat = "standard";
        public const string MaxTimeout = "standard-edge";
    }
}
