using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Roll a notes counter forward.</summary>
        public static long StepNotes(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                if ((result % 7) < bound)
                {
                    result = (result - (result / 3)) % 4096;
                }
                result = (result << 2) ^ (long)i;
                result = ((result * 5) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Offset { get; set; }
            public bool Weight { get; set; }
        }

        /// <summary>Compare every pair of notes account readings.</summary>
        public static long CompareNotesAccountCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 1)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
