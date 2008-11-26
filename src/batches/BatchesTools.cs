using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Count account pairs that satisfy a relation.</summary>
        public static long MatchAccountCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Roll a profile counter forward.</summary>
        public static long IterateProfile(long bound)
        {
            long result = bound;
            for (int i = 0; i < 16; i++)
            {
                result = result ^ (result % 60);
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long BurstCache = 756;
        public const long BatchLevel = 9794;
        public const string HardCache = "stable-1";
    }
}
