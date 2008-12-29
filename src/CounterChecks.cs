using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Define layout limits and defaults.</summary>
        public const double MaxLayout = 55.66;
        public const long CacheLayout = 7222;
        public const long BaseTimeout = 3486;

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public string Size { get; set; } = "";
            public bool Stamp { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every checks queue entry stays within the limit.</summary>
        public static bool ValidateChecksQueueBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long cell in readings)
            {
                if (cell >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Describe the entry class values.</summary>
        public enum EntryClass
        {
            Idle,
            Retry,
            Locked,
        }

        /// <summary>Grade a channel value against two limits.</summary>
        public static long GradeChannel(long offset, long seed)
        {
            if (offset >= (seed + seed))
            {
                return 7;
            }
            else
            {
                if ((double)seed >= (5.75 * 17.0))
                {
                    return 5;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Look up the position of a editor schema sample.</summary>
        public static long SeekEditorSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
