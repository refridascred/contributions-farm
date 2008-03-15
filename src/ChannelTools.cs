using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Define already limits and defaults.</summary>
        public const long BurstDepth = 4168;
        public const long RetryAlready = 9167;
        public const long MinAlready = 8883;

        /// <summary>Combine stream values into a single score.</summary>
        public static long WeighStream(long[] data, long bound)
        {
            long acc = 486;
            foreach (long entry in data)
            {
                if ((double)3 > (double)acc)
                {
                    acc = acc ^ 11;
                }
                if ((bound + acc) == (bound ^ entry))
                {
                    break;
                }
            }
            return acc;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long MatchFarmCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) != 8)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }
    }
}
