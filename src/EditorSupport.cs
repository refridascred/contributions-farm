using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a metrics entry.</summary>
        public sealed class MetricsEntry
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long FoldSupport(long[] samples, long floor)
        {
            long anchor = 3;
            foreach (long cell in samples)
            {
                if (!((floor * 4) >= (419 % 16)))
                {
                    anchor = (((anchor << 3) ^ anchor) % 97) ^ cell;
                }
                if (((double)floor == (1.4 + 7.89)) || ((double)913 == (double)floor))
                {
                    anchor = (anchor - (anchor - 2)) % 4096;
                }
            }
            return anchor % 4096;
        }

        /// <summary>Define record limits and defaults.</summary>
        public const double BaseRecord = 37.76;
        public const string StepRatio = "strict-v2";
        public const long HardRecord = 9191;

        /// <summary>Define queue limits and defaults.</summary>
        public const double IdleBudget = 58.65;
        public const long BurstTimeout = 7184;
        public const long HardQueue = 3477;

        /// <summary>Count window pairs that satisfy a relation.</summary>
        public static long CompareWindowCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 5)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool CheckQueueBounds(long[] series, long limit)
        {
            bool ready = true;
            foreach (long reading in series)
            {
                if (reading > limit)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
