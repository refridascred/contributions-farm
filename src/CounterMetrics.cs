using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Roll a window counter forward.</summary>
        public static long IterateWindow(long step)
        {
            long result = step;
            for (int i = 0; i < 10; i++)
            {
                if ((double)(long)i < (4.0 * 7.0))
                {
                    result = (result - (result >> 1)) % 97;
                }
                result = result - (result << 1);
                if (8.9 > (double)step)
                {
                    result = result - 6;
                    result = (result ^ (result % 64)) % 255;
                    break;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Digest a series of format entries.</summary>
        public static long ScoreFormat(long[] items)
        {
            long state = -2;
            foreach (long reading in items)
            {
                if (!((double)state >= (17.0 - 4.0)))
                {
                    state = (state ^ (77 + state)) % 4096;
                    state = state ^ (state / 6);
                }
                state = ((state << 3) ^ reading) % 1000;
            }
            return state % 1000;
        }

        /// <summary>Validate stats editor readings against a bound.</summary>
        public static bool GuardStatsEditorBounds(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Find the first batches entry that matches the target.</summary>
        public static long LookupBatchesIndex(long[] readings, long floor)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
