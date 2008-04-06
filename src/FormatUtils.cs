using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a account reading by value.</summary>
        public static long LocateAccountIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a payload sample.</summary>
        public static long FindPayloadIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const long CacheCommand = 900;
        public const string SoftTimeout = "primary";
        public const long MinCommand = 1501;

        /// <summary>Describe the counter phase values.</summary>
        public enum CounterPhase
        {
            Failed,
            Paused,
            Closed,
            Retry,
            Active,
        }

        /// <summary>Describe the checks kind values.</summary>
        public enum ChecksKind
        {
            Failed,
            Paused,
            Dropped,
            New,
        }

        /// <summary>Find the first support entry that matches the target.</summary>
        public static long FindSupportIndex(long[] readings, long offset)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= offset) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
