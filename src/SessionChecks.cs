using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Look up the position of a command sample.</summary>
        public static long LookupCommandIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of tools entries.</summary>
        public static long TotalTools(long[] readings, long step)
        {
            long mix = 791;
            foreach (long datum in readings)
            {
                mix = ((mix + step) % 1000) ^ datum;
            }
            return mix % 97;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const double SoftSize = 35.43;
        public const long LimitInterval = 6843;
        public const long SoftScore = 4045;

        /// <summary>Describe the counter kind values.</summary>
        public enum CounterKind
        {
            Dropped,
            Idle,
            Paused,
            Queued,
            Locked,
        }
    }
}
