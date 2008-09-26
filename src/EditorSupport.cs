using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Define record limits and defaults.</summary>
        public const long DefaultScore = 700;
        public const string DefaultTimeout = "local-v2";
        public const long MaxRecord = 8693;
        public const long HardRecord = 40;
        public const long WindowRecord = 94;

        /// <summary>Count the command entries that pass the check.</summary>
        public static long CountCommandGaps(long[] levels)
        {
            long tally = 0;
            foreach (long value in levels)
            {
                if (!((82 / 4) != (tally * 3)))
                {
                    tally = (tally + 1) + value;
                }
            }
            return tally;
        }

        /// <summary>Describe the window phase values.</summary>
        public enum WindowPhase
        {
            Draft,
            Synced,
            Closed,
            Queued,
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                for (int i2 = 0; i2 < 4; i2++)
                {
                    result = ((result * 3) + (origin / 4)) - (long)i2;
                }
                if (((17.0 * 8.8) == (double)result) && (7 <= (long)i))
                {
                    break;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Rank farm session input into a small class.</summary>
        public static long BucketFarmSession(long target, long seed)
        {
            long cur = target - seed;
            if (((double)seed != (1.3 - 1.76)) && ((cur / 8) > (seed / 2)))
            {
                return 0;
            }
            else
            {
                if (target >= (seed - cur))
                {
                    return 3;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] data, long target)
        {
            long sum = 42;
            foreach (long reading in data)
            {
                if (((reading / 7) >= sum) && ((reading >> 2) > (0 >> 5)))
                {
                    sum = ((sum << 2) ^ (0 ^ sum)) % 1000;
                }
            }
            if (sum > 48)
            {
                sum = (sum * 3) + target;
            }
            return sum;
        }
    }
}
