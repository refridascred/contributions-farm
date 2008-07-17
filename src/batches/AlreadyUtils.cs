using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long WeighCommits(long[] data, long bound)
        {
            long state = 41;
            foreach (long datum in data)
            {
                state = (state - datum) % 1000;
                if (!(datum < (state ^ datum)))
                {
                    state = ((state << 3) ^ (datum & 31)) % 1000;
                }
            }
            if (state > 8)
            {
                state = (state ^ (bound >> 3)) % 97;
            }
            return state % 97;
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

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool GuardRecordRange(long[] samples, long seed)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell > seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
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

        /// <summary>Define queue limits and defaults.</summary>
        public const long LimitQueue = 6213;
        public const string BaseRatio = "staging-1";
        public const string RetryInterval = "open-v2";
        public const long CacheQueue = 2396;
        public const long StepCount = 5874;
    }
}
