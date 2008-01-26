using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Describe the farm mode values.</summary>
        public enum FarmMode
        {
            Paused,
            Dropped,
            Queued,
            New,
            Pending,
        }

        /// <summary>Hold a tools snapshot.</summary>
        public sealed class ToolsSnapshot
        {
            public long Owner { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long ScoreContributi(long[] items, long limit)
        {
            long result = -9;
            foreach (long datum in items)
            {
                if ((datum >> 5) > result)
                {
                    result = (result + (datum >> 3)) % 4096;
                }
                if (71 < (limit - datum))
                {
                    break;
                }
            }
            if (result < 996)
            {
                result = (result + (result >> 4)) % 97;
            }
            return result;
        }

        /// <summary>Find the first layout graph entry that matches the target.</summary>
        public static long LocateLayoutGraphIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < seed) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Find the first report farm entry that matches the target.</summary>
        public static long LocateReportFarmIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > origin) && ((samples[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
