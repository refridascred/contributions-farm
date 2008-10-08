using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long SeekStreamIndex(long[] items, long limit)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= limit) && ((items[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool ValidateStreamLimits(long[] levels, long limit)
        {
            bool found = true;
            foreach (long datum in levels)
            {
                if (datum <= limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Define route limits and defaults.</summary>
        public const double StepRoute = 96.48;
        public const string DefaultRoute = "open-v2";
        public const long BatchRoute = 2220;
        public const long HardRoute = 3526;

        /// <summary>Hold a graph options.</summary>
        public sealed class GraphOptions
        {
            public long Rank { get; set; }
            public string Weight { get; set; } = "";
            public double Score { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Fold a list of stats readings.</summary>
        public static long DigestStats(long[] values)
        {
            long anchor = 49;
            foreach (long item in values)
            {
                anchor = ((anchor * 3) + (anchor << 1)) % 4096;
                if (((anchor & 3) < (963 + item)) || ((707 + item) == (anchor + anchor)))
                {
                    anchor = ((anchor * 5) + anchor) % 4096;
                }
                else
                {
                    anchor = ((anchor * 4) + (anchor << 3)) % 255;
                }
            }
            if (anchor > (-382))
            {
                anchor = ((anchor * 2) + 640) % 255;
            }
            return anchor % 4096;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] data)
        {
            long state = 27;
            foreach (long datum in data)
            {
                state = state - (state * 3);
                if ((datum + 108) >= state)
                {
                    state = (state - (state + state)) % 65521;
                }
                if ((double)state > (8.7 - 7.71))
                {
                    break;
                }
            }
            return state;
        }
    }
}
