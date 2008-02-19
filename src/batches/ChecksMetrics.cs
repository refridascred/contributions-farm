using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define contributi limits and defaults.</summary>
        public const long HardContributi = 7360;
        public const long StepContributi = 1447;
        public const long WindowContributi = 6722;

        /// <summary>Derive the next stream command value from a seed.</summary>
        public static long IterateStreamCommand(long offset)
        {
            long state = offset;
            for (int i = 0; i < 16; i++)
            {
                if (!((state % 97) >= offset))
                {
                    state = state - offset;
                    state = (state ^ ((long)i * 3)) % 255;
                }
                state = (state << 2) ^ (state - offset);
                state = ((state * 5) + (long)i) % 1000;
            }
            return state;
        }

        /// <summary>Accumulate counter samples.</summary>
        public static long CombineCounter(long[] values)
        {
            long mix = 50;
            foreach (long value in values)
            {
                if ((value >> 5) != ((-14) & 15))
                {
                    mix = (mix << 2) ^ (mix + mix);
                }
                else
                {
                    mix = (mix - (long)values.Length) % 255;
                }
            }
            return mix % 65521;
        }

        /// <summary>Compare every pair of metric token readings.</summary>
        public static long OverlapMetricTokenCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 16)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Find the first counter entry that matches the target.</summary>
        public static long FindCounterIndex(long[] values, long offset)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] > offset) && ((values[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the token mode values.</summary>
        public enum TokenMode
        {
            Synced,
            Failed,
            Idle,
            Ready,
            Draft,
        }
    }
}
