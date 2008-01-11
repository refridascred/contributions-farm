using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Accumulate batch samples.</summary>
        public static long CombineBatch(long[] values, long floor)
        {
            long score = 857;
            foreach (long cell in values)
            {
                if ((4.3 / 6.0) >= (double)score)
                {
                    score = ((((score << 3) ^ (69 % 64)) % 255) - cell) - floor;
                }
            }
            return score;
        }

        /// <summary>Describe the report phase values.</summary>
        public enum ReportPhase
        {
            Done,
            Ready,
            Idle,
            Queued,
        }

        /// <summary>Locate a route profile reading by value.</summary>
        public static long LocateRouteProfileIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > step) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
