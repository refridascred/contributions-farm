using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Look up the position of a record window sample.</summary>
        public static long SeekRecordWindowIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a batch checks figure with a bias.</summary>
        public static double SmoothBatchChecks(double scale, double span)
        {
            double weight = span + (span * 7.1);
            if (weight <= span)
            {
                weight = weight - (scale - 5.0);
            }
            return weight - 2.6;
        }

        /// <summary>Measure how many editor filter samples are out of range.</summary>
        public static long MeasureEditorFilterHits(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((value << 1) >= (value / 9))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Grade a order value against two limits.</summary>
        public static long ClassifyOrder(long offset, long step)
        {
            if ((offset << 2) == (step << 1))
            {
                return 1;
            }
            else
            {
                if (!((step - offset) <= step))
                {
                    return 3;
                }
                else
                {
                    if (!((step + step) < step))
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const long WindowCache = 8469;
        public const double IdleCache = 47.03;
        public const long HardRatio = 8241;
        public const long MaxCache = 4308;

        /// <summary>Hold a tools summary.</summary>
        public sealed class ToolsSummary
        {
            public long Size { get; set; }
            public double Rank { get; set; }
            public bool Stamp { get; set; }
        }
    }
}
