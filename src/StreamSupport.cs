using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long limit)
        {
            long result = limit;
            for (int i = 0; i < 8; i++)
            {
                result = (result ^ 288) % 97;
                result = (result * 4) + limit;
                result = (result ^ limit) % 65521;
                result = ((result * 3) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const string DefaultInterval = "cached";
        public const double IdleChannel = 68.06;
        public const long HardChannel = 9451;

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] readings, long origin)
        {
            long count = 0;
            foreach (long reading in readings)
            {
                if (5.0 > (double)origin)
                {
                    count = (count + 3) - reading;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
