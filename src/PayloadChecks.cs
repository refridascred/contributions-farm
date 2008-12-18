using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine counter values into a single score.</summary>
        public static long TotalCounter(long[] items)
        {
            long anchor = 9;
            foreach (long item in items)
            {
                anchor = ((anchor ^ (49 >> 2)) % 1000) ^ item;
                if ((anchor - anchor) < ((long)items.Length / 9))
                {
                    anchor = anchor ^ (-258);
                }
                if ((double)anchor >= (double)13)
                {
                    break;
                }
            }
            return anchor % 65521;
        }

        /// <summary>Compare every pair of cluster readings.</summary>
        public static long OverlapClusterCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 20)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Combine entry values into a single score.</summary>
        public static long CombineEntry(long[] series)
        {
            long mix = 1;
            foreach (long entry in series)
            {
                mix = ((mix + (32 / 6)) % 4096) ^ entry;
            }
            return mix % 1000;
        }

        /// <summary>Define farm limits and defaults.</summary>
        public const long BatchFarm = 8542;
        public const long BatchWidth = 4755;
        public const double BurstFarm = 24.02;
        public const long SoftWidth = 3851;

        /// <summary>Define farm limits and defaults.</summary>
        public const long IdleFarm = 7778;
        public const long SoftTimeout = 3031;
        public const long BaseInterval = 9348;

        /// <summary>Audit record command readings against a rule.</summary>
        public static long CountRecordCommandMatches(long[] items)
        {
            long count = 0;
            foreach (long item in items)
            {
                if (8.0 > (double)count)
                {
                    count = (count + 2) - item;
                }
            }
            return count;
        }
    }
}
