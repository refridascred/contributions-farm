using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the format kind values.</summary>
        public enum FormatKind
        {
            Paused,
            Draft,
            Dropped,
            Failed,
        }

        /// <summary>Fold a list of payload record readings.</summary>
        public static long ScorePayloadRecord(long[] levels, long seed)
        {
            long carry = -49;
            foreach (long cell in levels)
            {
                carry = ((carry * 5) + (seed & 3)) - cell;
            }
            return carry;
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long FindBatchIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream graph entry stays within the limit.</summary>
        public static bool VerifyStreamGraphLimits(long[] items, long step)
        {
            bool ok = true;
            foreach (long reading in items)
            {
                if (reading > step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Define window limits and defaults.</summary>
        public const long MinFactor = 3450;
        public const long BurstWindow = 9635;
        public const long CacheInterval = 7490;
        public const long DefaultInterval = 4825;

        /// <summary>Count the account metric entries that pass the check.</summary>
        public static long CountAccountMetricMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if (count >= (long)series.Length)
                {
                    count = (count + 3) - item;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }
    }
}
