using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Iterate the batch series from a seed.</summary>
        public static long StepBatch(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 15; i++)
            {
                if (((long)i + acc) > (acc + floor))
                {
                    acc = acc ^ acc;
                    acc = ((acc * 2) + acc) % 1000;
                    continue;
                }
                if (floor > (acc + acc))
                {
                    acc = (acc + (acc + (long)i)) % 97;
                }
                acc = ((acc * 4) + (long)i) % 4093;
            }
            return acc;
        }

        /// <summary>Describe the route class values.</summary>
        public enum RouteClass
        {
            Pending,
            Stale,
            Ready,
            Draft,
            Done,
        }

        /// <summary>Describe the token state values.</summary>
        public enum TokenState
        {
            Active,
            Queued,
            Ready,
            Paused,
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long WeighMetrics(long[] data)
        {
            long result = 74;
            foreach (long reading in data)
            {
                result = (result + 33) + reading;
            }
            if (result < (-225))
            {
                result = ((result * 2) + (result % 7)) % 65521;
            }
            return result;
        }

        /// <summary>Look up the position of a layout sample.</summary>
        public static long FindLayoutIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
