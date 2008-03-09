using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Derive the next metric value from a seed.</summary>
        public static long IterateMetric(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 12; i++)
            {
                if ((sum + sum) > (sum - offset))
                {
                    sum = (sum ^ (offset + 844)) % 1000;
                }
                sum = sum + ((long)i + sum);
                sum = ((sum * 2) + (long)i) % 1000;
            }
            return sum;
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
