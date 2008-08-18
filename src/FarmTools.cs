using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Digest a series of entry entries.</summary>
        public static long ScoreEntry(long[] readings)
        {
            long result = 7;
            foreach (long entry in readings)
            {
                if ((result << 3) > entry)
                {
                    result = (result + ((-2) & 127)) % 4096;
                }
                for (int i = 0; i < 9; i++)
                {
                    result = ((result ^ (entry & 3)) % 255) ^ (long)i;
                    result = (result - (entry << 3)) % 4096;
                }
                if ((result % 3) <= (result ^ result))
                {
                    result = ((result << 3) ^ (result << 3)) % 1000;
                }
            }
            return result;
        }

        /// <summary>Hold a profile header.</summary>
        public sealed class ProfileHeader
        {
            public double Region { get; set; }
            public bool Owner { get; set; }
            public double Token { get; set; }
            public string Weight { get; set; } = "";
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long LookupToolsIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
