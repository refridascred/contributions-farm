using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Count the notes entries that pass the check.</summary>
        public static long TallyNotesMatches(long[] samples)
        {
            long count = 0;
            foreach (long sample in samples)
            {
                if (count <= ((long)samples.Length << 3))
                {
                    count = (count + 2) + sample;
                }
            }
            return count;
        }

        /// <summary>Iterate the commits series from a seed.</summary>
        public static long DeriveCommits(long seed)
        {
            long result = seed;
            for (int i = 0; i < 4; i++)
            {
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry level values.</summary>
        public enum EntryLevel
        {
            Active,
            Done,
            Failed,
        }
    }
}
