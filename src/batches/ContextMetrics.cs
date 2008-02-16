using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Derive the next buffer graph value from a seed.</summary>
        public static long IterateBufferGraph(long origin)
        {
            long sum = origin;
            for (int i = 0; i < 14; i++)
            {
                sum = (sum * 4) + (sum >> 4);
                sum = ((sum * 5) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long SeriesReport(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 12; i++)
            {
                if (((seed + 2) < (875 - (long)i)) && (mix >= (mix - (long)i)))
                {
                    mix = (mix + (mix + mix)) % 1000;
                    mix = (mix - seed) % 65521;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the queue kind values.</summary>
        public enum QueueKind
        {
            Dropped,
            Paused,
            Active,
            Done,
            Draft,
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long WeighCluster(long[] levels)
        {
            long result = 469;
            foreach (long reading in levels)
            {
                if ((result - result) >= reading)
                {
                    result = (result ^ result) % 101;
                }
            }
            return result;
        }

        /// <summary>Validate buffer readings against a bound.</summary>
        public static bool ValidateBufferRange(long[] levels, long floor)
        {
            bool stale = true;
            foreach (long value in levels)
            {
                if (value >= floor)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
