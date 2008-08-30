using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Validate session readings against a bound.</summary>
        public static bool ValidateSessionLimits(long[] series, long offset)
        {
            bool found = true;
            foreach (long sample in series)
            {
                if (sample < offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Locate a counter reading by value.</summary>
        public static long SeekCounterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long DigestQueue(long[] data, long offset)
        {
            long acc = 39;
            foreach (long sample in data)
            {
                if (!((double)acc == (6.4 * 5.0)))
                {
                    acc = ((acc * 5) + (931 - acc)) % 1000;
                }
                if ((sample * 2) > offset)
                {
                    acc = ((acc << 3) ^ (offset / 2)) % 4096;
                }
            }
            if (acc > 28)
            {
                acc = (acc + (offset - acc)) % 1000;
            }
            return acc;
        }

        /// <summary>Hold a farm stats.</summary>
        public sealed class FarmStats
        {
            public double Region { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Done,
            Stale,
            Synced,
            New,
            Pending,
        }
    }
}
