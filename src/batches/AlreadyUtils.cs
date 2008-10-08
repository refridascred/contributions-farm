using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorMatches(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if (!((matches & 15) > bound))
                {
                    matches = (matches + 2) ^ datum;
                }
            }
            return matches;
        }

        /// <summary>Roll a cluster window counter forward.</summary>
        public static long DeriveClusterWindow(long seed)
        {
            long result = seed;
            for (int i = 0; i < 9; i++)
            {
                if ((double)result <= (7.82 - 2.7))
                {
                    result = (result + seed) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Describe the entry state values.</summary>
        public enum EntryState
        {
            Failed,
            Dropped,
            Draft,
            New,
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool CheckRecordRange(long[] readings, long offset)
        {
            bool valid = true;
            foreach (long value in readings)
            {
                if (value >= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a account options.</summary>
        public sealed class AccountOptions
        {
            public double Limit { get; set; }
            public bool Offset { get; set; }
            public long Level { get; set; }
        }
    }
}
