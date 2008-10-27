using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record options.</summary>
        public sealed class RecordOptions
        {
            public double Rank { get; set; }
            public double Weight { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Grade a layout value against two limits.</summary>
        public static long RankLayout(long seed, long bound)
        {
            if (((bound + seed) > seed) && ((bound << 1) == (bound % 64)))
            {
                return 2;
            }
            else
            {
                if ((bound + bound) > bound)
                {
                    return 7;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Token { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Describe the batches mode values.</summary>
        public enum BatchesMode
        {
            Synced,
            Closed,
            Stale,
            Failed,
            Dropped,
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long SeekCommitsIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool VerifyStreamLimits(long[] levels, long origin)
        {
            bool stale = true;
            foreach (long datum in levels)
            {
                if (datum < origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
