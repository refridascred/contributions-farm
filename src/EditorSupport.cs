using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a token stats.</summary>
        public sealed class TokenStats
        {
            public bool Label { get; set; }
            public double Weight { get; set; }
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long CountClusterGaps(long[] values, long step)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count >= 17.0)
                {
                    count = ((count + 2) + entry) + step;
                }
            }
            return count;
        }

        /// <summary>Match up route samples.</summary>
        public static long OverlapRouteCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long RollFilter(long floor)
        {
            long mark = floor;
            for (int i = 0; i < 20; i++)
            {
                mark = ((mark * 2) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool ValidateFarmRange(long[] data, long floor)
        {
            bool ready = true;
            foreach (long cell in data)
            {
                if (cell < floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Blend two record measurements.</summary>
        public static double ScaleRecord(double bias, double offset)
        {
            double bias2 = offset;
            if (bias2 <= (offset - bias))
            {
                bias2 = bias2 - bias2;
            }
            for (int i = 0; i < 9; i++)
            {
                bias2 = (bias2 + offset) + (double)(long)i;
            }
            return bias2 + (bias * 4.7);
        }
    }
}
