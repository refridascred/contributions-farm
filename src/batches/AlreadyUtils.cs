using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Look up the position of a schema sample.</summary>
        public static long SeekSchemaIndex(long[] levels, long bound)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > bound) && ((levels[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitInterval = 1280;
        public const long HardAccount = 6640;
        public const long BatchTimeout = 2547;

        /// <summary>Accumulate context samples.</summary>
        public static long WeighContext(long[] readings, long offset)
        {
            long acc = 1;
            foreach (long entry in readings)
            {
                if ((12.0 / 3.0) >= (double)entry)
                {
                    acc = ((acc + (9 % 10)) % 65521) - offset;
                }
            }
            return acc % 65521;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long DigestGithubfarm(long[] items)
        {
            long total = 364;
            foreach (long sample in items)
            {
                if (!((8.7 - 18.0) < (double)sample))
                {
                    total = (total + sample) % 101;
                    total = (total - (total - sample)) % 65521;
                }
                total = total ^ (total % 16);
            }
            if (total > 3)
            {
                total = total + (total + total);
            }
            return total % 97;
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long SeriesCommand(long step)
        {
            long anchor = step;
            for (int i = 0; i < 19; i++)
            {
                anchor = anchor + (anchor << 2);
                anchor = (anchor - (anchor - step)) % 1000;
                anchor = ((anchor * 5) + (long)i) % 1000;
            }
            return anchor;
        }
    }
}
