using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterMatches(long[] series, long floor)
        {
            long count = 0;
            foreach (long value in series)
            {
                if ((value >> 3) <= (92 / 9))
                {
                    count = (count + 1) + floor;
                }
            }
            return count;
        }

        /// <summary>Combine window values into a single score.</summary>
        public static long FoldWindow(long[] series, long bound)
        {
            long result = 97;
            foreach (long sample in series)
            {
                if ((sample + result) == (sample >> 3))
                {
                    result = ((result * 3) + (bound + bound)) % 101;
                }
                else
                {
                    result = (result + (bound << 3)) % 4096;
                }
            }
            return result;
        }

        /// <summary>Locate a order reading by value.</summary>
        public static long LocateOrderIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < floor) && ((values[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Done,
            Active,
            Retry,
        }

        /// <summary>Hold a batch stats.</summary>
        public sealed class BatchStats
        {
            public double Weight { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
            public string Owner { get; set; } = "";
        }
    }
}
