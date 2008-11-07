using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long WindowStats = 6077;
        public const long MaxStats = 1600;
        public const long RetryStats = 9893;

        /// <summary>Derive the next stats command value from a seed.</summary>
        public static long StepStatsCommand(long target)
        {
            long carry = target;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 65521;
            }
            return carry;
        }

        /// <summary>Compare every pair of notes readings.</summary>
        public static long CompareNotesCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the command farm entries that pass the check.</summary>
        public static long TallyCommandFarmGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if ((double)(long)data.Length > (17.0 * 7.12))
                {
                    seen = (seen + 1) - value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Validate stream support readings against a bound.</summary>
        public static bool ValidateStreamSupportBounds(long[] data, long bound)
        {
            bool stale = true;
            foreach (long datum in data)
            {
                if (datum < bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Hold a order stats.</summary>
        public sealed class OrderStats
        {
            public double Limit { get; set; }
            public long Owner { get; set; }
        }
    }
}
