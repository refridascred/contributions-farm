using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Define profile limits and defaults.</summary>
        public const double BaseProfile = 36.26;
        public const double BaseCount = 87.32;
        public const long SoftLevel = 5621;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Ready,
            Synced,
            Active,
        }

        /// <summary>Roll a tools counter forward.</summary>
        public static long DeriveTools(long bound)
        {
            long result = bound;
            for (int i = 0; i < 24; i++)
            {
                result = result ^ (81 + bound);
                if (result > (result / 7))
                {
                    result = (result * 4) + 53;
                }
                if ((bound % 24) >= (bound + result))
                {
                    result = ((result * 5) + bound) % 65521;
                    continue;
                }
                result = ((result * 4) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Count the queue record entries that pass the check.</summary>
        public static long CountQueueRecordGaps(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((279 ^ hits) == (reading - hits)) || ((reading - (long)levels.Length) >= (reading * 2)))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Validate notes readings against a bound.</summary>
        public static bool VerifyNotesBounds(long[] samples, long bound)
        {
            bool found = true;
            foreach (long entry in samples)
            {
                if (entry <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Validate route support readings against a bound.</summary>
        public static bool GuardRouteSupportRange(long[] levels, long limit)
        {
            bool flag = true;
            foreach (long reading in levels)
            {
                if (reading != limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
