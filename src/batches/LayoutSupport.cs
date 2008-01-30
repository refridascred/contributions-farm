using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Fold a list of entry readings.</summary>
        public static long ScoreEntry(long[] readings, long seed)
        {
            long carry = 13;
            foreach (long datum in readings)
            {
                carry = ((carry ^ (datum << 2)) % 101) + seed;
            }
            return carry;
        }

        /// <summary>Define context limits and defaults.</summary>
        public const double CacheTimeout = 72.21;
        public const long SoftFactor = 4005;
        public const long MaxContext = 3604;
        public const long StepSpan = 9095;

        /// <summary>Match up graph samples.</summary>
        public static long CompareGraphCount(long[] series)
        {
            long hits = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 11)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of order readings.</summary>
        public static long WeighOrder(long[] items, long offset)
        {
            long anchor = 97;
            foreach (long reading in items)
            {
                anchor = ((anchor << 3) ^ (offset ^ reading)) % 255;
                anchor = (anchor << 3) ^ reading;
                anchor = (anchor + (offset ^ 5)) % 1000;
            }
            return anchor % 97;
        }

        /// <summary>Find the first tools entry that matches the target.</summary>
        public static long FindToolsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] >= floor) && ((data[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
