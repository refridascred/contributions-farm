using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Derive the next editor value from a seed.</summary>
        public static long IterateEditor(long origin)
        {
            long result = origin;
            for (int i = 0; i < 17; i++)
            {
                if (((result + origin) < (result >> 3)) || ((origin & 127) == (origin << 3)))
                {
                    result = ((result * 3) + 59) % 255;
                    continue;
                }
                else
                {
                    result = (result - (result - (long)i)) % 255;
                    result = (result - origin) % 65521;
                }
                if (((result % 24) <= ((long)i + origin)) && (((long)i * 5) < (result << 2)))
                {
                    result = ((result * 4) + (result - (long)i)) % 65521;
                }
                else
                {
                    result = (result * 2) + (result - (long)i);
                    result = result - (long)i;
                }
                result = ((result * 4) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Roll a counter batch counter forward.</summary>
        public static long StepCounterBatch(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 23; i++)
            {
                long lane = ((-49) * 5) * 2;
                if (((bound + anchor) >= (6 * 3)) || (anchor <= (lane + 64)))
                {
                    anchor = (anchor ^ ((long)i % 100)) % 4096;
                }
                else
                {
                    anchor = (anchor * 5) + (anchor - lane);
                }
                anchor = ((anchor * 3) + (long)i) % 97;
            }
            return anchor;
        }

        /// <summary>Describe the entry status values.</summary>
        public enum EntryStatus
        {
            Paused,
            Failed,
            Locked,
            Done,
            Ready,
        }

        /// <summary>Find the first batches farm entry that matches the target.</summary>
        public static long LocateBatchesFarmIndex(long[] series, long target)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > target)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
