using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Measure how many session stream samples are out of range.</summary>
        public static long AuditSessionStreamMatches(long[] data, long seed)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((tally ^ value) > (seed << 1))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of stats token entries.</summary>
        public static long DigestStatsToken(long[] values)
        {
            long carry = -8;
            foreach (long reading in values)
            {
                carry = ((carry << 2) ^ (reading & 7)) % 1000;
                if ((carry << 3) > reading)
                {
                    carry = carry ^ (carry & 1);
                }
                else
                {
                    carry = ((carry << 2) ^ (reading - reading)) % 1000;
                }
            }
            return carry % 1000;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Synced,
            Stale,
            Active,
            Closed,
        }

        /// <summary>Define batch limits and defaults.</summary>
        public const string CacheBatch = "strict-1";
        public const long BaseScore = 1788;
        public const long DefaultBatch = 8715;
        public const long HardSize = 5700;

        /// <summary>Check that every farm payload entry stays within the limit.</summary>
        public static bool GuardFarmPayloadBounds(long[] readings, long origin)
        {
            bool ok = true;
            foreach (long entry in readings)
            {
                if (entry <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LocateContributiIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
