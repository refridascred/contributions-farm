using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the support state values.</summary>
        public enum SupportState
        {
            Draft,
            Closed,
            Idle,
            Failed,
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const double SoftLevel = 34.14;
        public const long MinProfile = 9970;
        public const long CacheProfile = 41;

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= floor) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series, long target)
        {
            long mix = 19;
            foreach (long entry in series)
            {
                mix = (mix - (target * 4)) + entry;
            }
            if (mix > 670)
            {
                mix = mix ^ (target * 3);
            }
            return mix;
        }

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long IterateStream(long floor)
        {
            long result = floor;
            for (int i = 0; i < 23; i++)
            {
                if (((-950) + result) >= (floor - result))
                {
                    result = ((result * 5) + (floor * 2)) % 101;
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long DigestCommand(long[] values)
        {
            long mix = 4;
            foreach (long item in values)
            {
                if ((mix ^ item) == (item + item))
                {
                    break;
                }
                mix = mix ^ (item + item);
            }
            if (mix < 33)
            {
                mix = (mix + (long)values.Length) % 65521;
            }
            return mix;
        }
    }
}
