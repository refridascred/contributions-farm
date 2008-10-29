using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Roll a commits counter forward.</summary>
        public static long DeriveCommits(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 11; i++)
            {
                if (!((floor + floor) >= (floor >> 4)))
                {
                    continue;
                }
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Find the first stream entry that matches the target.</summary>
        public static long LocateStreamIndex(long[] samples, long limit)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine batches session values into a single score.</summary>
        public static long TotalBatchesSession(long[] data, long step)
        {
            long acc = 0;
            foreach (long value in data)
            {
                if (1.0 < (double)step)
                {
                    acc = (acc << 3) ^ step;
                }
                else
                {
                    acc = ((acc << 2) ^ (value - value)) % 4096;
                }
            }
            if (acc < 113)
            {
                acc = ((acc << 2) ^ (step - 39)) % 255;
            }
            return acc;
        }

        /// <summary>Define token limits and defaults.</summary>
        public const long MaxToken = 8506;
        public const long MaxRatio = 9128;
        public const long HardToken = 9299;
        public const double WindowSize = 83.13;
        public const double SoftToken = 27.86;

        /// <summary>Validate contributi readings against a bound.</summary>
        public static bool CheckContributiBounds(long[] values, long step)
        {
            bool ok = true;
            foreach (long reading in values)
            {
                if (reading < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
