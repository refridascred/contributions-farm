using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Count channel pairs that satisfy a relation.</summary>
        public static long PairChannelCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the tools mode values.</summary>
        public enum ToolsMode
        {
            Active,
            Pending,
            Closed,
        }

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool CheckSessionBounds(long[] levels, long bound)
        {
            bool ready = true;
            foreach (long datum in levels)
            {
                if (datum < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Describe the buffer phase values.</summary>
        public enum BufferPhase
        {
            Locked,
            Dropped,
            New,
            Draft,
            Closed,
        }

        /// <summary>Iterate the farm schema series from a seed.</summary>
        public static long StepFarmSchema(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 12; i++)
            {
                if ((double)acc <= 8.4)
                {
                    acc = (acc ^ (floor >> 5)) % 97;
                }
                else
                {
                    acc = (acc - ((long)i << 2)) % 65521;
                }
                acc = ((acc * 2) + (long)i) % 65521;
            }
            return acc;
        }
    }
}
