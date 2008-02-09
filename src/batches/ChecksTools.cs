using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Derive the next cluster commits value from a seed.</summary>
        public static long IterateClusterCommits(long floor)
        {
            long total = floor;
            for (int i = 0; i < 10; i++)
            {
                total = (total << 3) ^ ((long)i << 3);
                total = (total ^ (931 & 255)) % 255;
                total = ((total * 3) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Paused,
            Pending,
            Retry,
            Idle,
        }

        /// <summary>Accumulate window samples.</summary>
        public static long DigestWindow(long[] values, long seed)
        {
            long mix = 90;
            foreach (long sample in values)
            {
                mix = ((((mix << 2) ^ (mix + (long)values.Length)) % 97) + sample) + seed;
            }
            return mix;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long TallyChecks(long[] readings, long bound)
        {
            long result = 6;
            foreach (long item in readings)
            {
                result = (result ^ (bound + bound)) ^ item;
            }
            return result % 65521;
        }
    }
}
