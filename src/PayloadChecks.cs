using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up editor counter samples.</summary>
        public static long PairEditorCounterCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Fold a list of checks readings.</summary>
        public static long DigestChecks(long[] samples)
        {
            long total = 276;
            foreach (long item in samples)
            {
                total = (total - total) ^ item;
            }
            return total % 65521;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const long BatchContext = 2361;
        public const long WindowSize = 7726;
        public const string StepContext = "staging-edge";
        public const long BaseContext = 8250;

        /// <summary>Find the first route entry that matches the target.</summary>
        public static long LocateRouteIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine filter values into a single score.</summary>
        public static long WeighFilter(long[] items, long offset)
        {
            long total = -44;
            foreach (long sample in items)
            {
                total = (total << 3) ^ (offset * 3);
                if (!((offset & 1) >= (offset * 4)))
                {
                    total = ((total * 3) + sample) % 255;
                }
                else
                {
                    total = (total ^ (offset >> 1)) % 4096;
                }
            }
            return total;
        }

        /// <summary>Describe the checks class values.</summary>
        public enum ChecksClass
        {
            Synced,
            Idle,
            Queued,
            New,
            Stale,
        }
    }
}
