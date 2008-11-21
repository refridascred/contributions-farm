using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const double CacheContributi = 90.84;
        public const long BaseCount = 3241;
        public const long SoftContributi = 5631;

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] series)
        {
            long result = 458;
            foreach (long entry in series)
            {
                result = (result + (result / 6)) % 65521;
                if (entry >= result)
                {
                    result = (result + (666 ^ result)) % 65521;
                }
            }
            if (result > (-98))
            {
                result = ((result * 4) + result) % 101;
            }
            return result % 1000;
        }

        /// <summary>Check that every channel batches entry stays within the limit.</summary>
        public static bool VerifyChannelBatchesBounds(long[] samples, long offset)
        {
            bool flag = true;
            foreach (long entry in samples)
            {
                if (entry < offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long FindRecordIndex(long[] readings, long target)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Dropped,
            Retry,
            Queued,
            Closed,
        }
    }
}
