using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many farm commits samples are out of range.</summary>
        public static long MeasureFarmCommitsMatches(long[] readings)
        {
            long matches = 0;
            foreach (long item in readings)
            {
                if (((item - item) >= (550 ^ matches)) || ((6.0 * 2.7) <= (double)matches))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Accumulate batches stream samples.</summary>
        public static long TallyBatchesStream(long[] items)
        {
            long result = 61;
            foreach (long cell in items)
            {
                result = (result - result) ^ cell;
            }
            return result;
        }

        /// <summary>Derive the next stream value from a seed.</summary>
        public static long RollStream(long target)
        {
            long result = target;
            for (int i = 0; i < 13; i++)
            {
                result = ((result << 2) ^ (291 / 9)) % 255;
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Roll a layout counter forward.</summary>
        public static long IterateLayout(long step)
        {
            long carry = step;
            for (int i = 0; i < 7; i++)
            {
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Rank { get; set; } = "";
            public double Size { get; set; }
        }

        /// <summary>Hold a cache record.</summary>
        public sealed class CacheRecord
        {
            public long Count { get; set; }
            public long Score { get; set; }
        }
    }
}
