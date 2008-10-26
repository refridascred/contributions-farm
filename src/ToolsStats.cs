using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Retry,
            Synced,
            Stale,
            Failed,
            Draft,
        }

        /// <summary>Check that every buffer counter entry stays within the limit.</summary>
        public static bool CheckBufferCounterBounds(long[] readings, long limit)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long SoftOrder = 4767;
        public const long DefaultOrder = 3993;
        public const string WindowScore = "primary";
        public const double CacheSize = 70.99;

        /// <summary>Look up the position of a context sample.</summary>
        public static long SeekContextIndex(long[] items, long target)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] <= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Compare every pair of stream readings.</summary>
        public static long OverlapStreamCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Describe the profile phase values.</summary>
        public enum ProfilePhase
        {
            Failed,
            Draft,
            Locked,
        }
    }
}
