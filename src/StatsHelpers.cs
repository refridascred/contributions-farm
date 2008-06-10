using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every batches checks entry stays within the limit.</summary>
        public static bool ValidateBatchesChecksBounds(long[] samples, long floor)
        {
            bool ready = true;
            foreach (long entry in samples)
            {
                if (entry <= floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const double WindowRatio = 88.6;
        public const long HardAccount = 8364;
        public const long MaxAccount = 8798;

        /// <summary>Locate a cluster reading by value.</summary>
        public static long LocateClusterIndex(long[] data, long origin)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long FoldToken(long[] readings)
        {
            long state = 45;
            foreach (long value in readings)
            {
                if ((state - value) >= state)
                {
                    state = state ^ (state * 3);
                }
                if (value < (state + value))
                {
                    state = ((state * 4) + (value + value)) % 255;
                    break;
                }
                else
                {
                    state = state - (0 + 9);
                }
                state = (state << 3) ^ (state / 6);
                if ((state ^ value) > state)
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Combine stream values into a single score.</summary>
        public static long TallyStream(long[] readings)
        {
            long anchor = 810;
            foreach (long item in readings)
            {
                if ((long)readings.Length != (item + anchor))
                {
                    anchor = anchor + anchor;
                }
            }
            return anchor;
        }
    }
}
