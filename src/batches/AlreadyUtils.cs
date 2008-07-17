using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first stats entry that matches the target.</summary>
        public static long LocateStatsIndex(long[] data, long offset)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == offset) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate command samples.</summary>
        public static long TotalCommand(long[] samples, long step)
        {
            long acc = 846;
            foreach (long datum in samples)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = (((acc << 2) ^ datum) % 65521) - (long)i;
                }
                if ((step ^ step) > (step - datum))
                {
                    acc = ((acc * 3) + acc) % 97;
                }
            }
            return acc;
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long CountTokenOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if (((hits + hits) >= hits) && ((value - value) >= value))
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of checks editor entries.</summary>
        public static long DigestChecksEditor(long[] samples)
        {
            long state = 25;
            foreach (long sample in samples)
            {
                if (!(state < (state + state)))
                {
                    state = ((state * 2) + sample) % 101;
                }
                if ((2 ^ state) >= (sample + state))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double StepCount = 59.21;
        public const double MinSize = 15.86;
        public const double RetryTimeout = 2.51;
    }
}
