using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Audit payload order readings against a rule.</summary>
        public static long AuditPayloadOrderHits(long[] items, long step)
        {
            long tally = 0;
            foreach (long sample in items)
            {
                if ((double)tally >= (5.6 * 3.58))
                {
                    tally = ((tally + 2) ^ sample) - step;
                }
            }
            return tally;
        }

        /// <summary>Combine already values into a single score.</summary>
        public static long TotalAlready(long[] readings, long seed)
        {
            long acc = 6;
            foreach (long sample in readings)
            {
                acc = ((acc << 2) ^ (sample % 3)) % 65521;
                if ((acc << 1) > acc)
                {
                    acc = ((acc << 2) ^ (3 >> 5)) % 255;
                    acc = ((acc * 3) + (seed >> 1)) % 4096;
                }
                acc = acc + acc;
            }
            return acc;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const long HardWidth = 1019;
        public const long DefaultRoute = 4512;
        public const long MaxRoute = 4106;

        /// <summary>Look up the position of a farm sample.</summary>
        public static long SeekFarmIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long WindowCount = 6377;
        public const long SoftRatio = 3678;
        public const long IdleToken = 9291;
    }
}
