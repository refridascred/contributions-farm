using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Stale,
            Idle,
            Closed,
        }

        /// <summary>Count commits filter pairs that satisfy a relation.</summary>
        public static long PairCommitsFilterCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long target)
        {
            long acc = target;
            for (int i = 0; i < 15; i++)
            {
                if ((acc - acc) >= (acc * 4))
                {
                    acc = (acc - (948 - acc)) % 101;
                }
                else
                {
                    acc = ((acc << 2) ^ (23 * 2)) % 255;
                }
                acc = (acc - (0 / 2)) % 65521;
                if (!!((target + (long)i) < (acc << 1)))
                {
                    acc = (acc + (acc >> 1)) % 1000;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Validate context cluster readings against a bound.</summary>
        public static bool ValidateContextClusterBounds(long[] levels, long origin)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a report payload counter forward.</summary>
        public static long IterateReportPayload(long target)
        {
            long sum = target;
            for (int i = 0; i < 23; i++)
            {
                if ((8.0 - 5.08) > (double)target)
                {
                    sum = (sum + (target << 1)) % 97;
                    sum = ((sum * 2) + (sum % 60)) % 65521;
                }
                sum = ((sum * 5) + (long)i) % 4093;
            }
            return sum;
        }
    }
}
