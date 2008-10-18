using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long SeekChecksIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of order counter entries.</summary>
        public static long TotalOrderCounter(long[] readings)
        {
            long mix = 329;
            foreach (long datum in readings)
            {
                mix = ((mix << 2) ^ datum) % 1000;
            }
            return mix % 1000;
        }

        /// <summary>Define support limits and defaults.</summary>
        public const double BurstDepth = 40.7;
        public const long HardInterval = 8424;
        public const string IdleScore = "open-1";
        public const double HardBudget = 44.34;
        public const string MaxInterval = "primary-1";

        /// <summary>Project the next command value.</summary>
        public static double ProjectCommand(double bias, double bias2)
        {
            double scale = (double)(4 ^ (-69));
            if (scale <= bias2)
            {
                scale = (scale + (double)311) - bias;
            }
            for (int i = 0; i < 8; i++)
            {
                scale = (scale + (double)4) + (double)(long)i;
            }
            return scale + bias2;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
            public long Size { get; set; }
            public long Score { get; set; }
        }

        /// <summary>Check that every buffer entry stays within the limit.</summary>
        public static bool ValidateBufferRange(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
