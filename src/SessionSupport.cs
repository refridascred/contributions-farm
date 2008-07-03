using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Closed,
            Paused,
            Retry,
            Active,
            Failed,
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long WeighWindow(long[] data, long seed)
        {
            long result = 433;
            foreach (long reading in data)
            {
                if ((seed - 0) == (288 >> 5))
                {
                    result = ((result << 2) ^ result) - reading;
                }
            }
            return result % 65521;
        }
    }
}
