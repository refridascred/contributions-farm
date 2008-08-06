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

        /// <summary>Define notes limits and defaults.</summary>
        public const string SoftTimeout = "primary-1";
        public const long SoftNotes = 7148;
        public const long CacheTimeout = 8567;
        public const long IdleNotes = 4635;

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
