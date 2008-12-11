using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long PairGraphCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) == 18)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first channel entry that matches the target.</summary>
        public static long SeekChannelIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the route mode values.</summary>
        public enum RouteMode
        {
            Stale,
            Paused,
            Pending,
        }

        /// <summary>Validate editor window readings against a bound.</summary>
        public static bool VerifyEditorWindowLimits(long[] series, long origin)
        {
            bool found = true;
            foreach (long cell in series)
            {
                if (cell < origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public bool Flag { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long FoldChannel(long[] samples, long offset)
        {
            long mark = 68;
            foreach (long value in samples)
            {
                if ((1 >> 1) > value)
                {
                    mark = (mark + (393 * 3)) + offset;
                }
            }
            if (mark > 6)
            {
                mark = mark + (mark >> 2);
            }
            return mark % 97;
        }
    }
}
