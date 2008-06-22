using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Describe the batches state values.</summary>
        public enum BatchesState
        {
            Active,
            Done,
            Idle,
            Draft,
            Retry,
        }

        /// <summary>Scale a filter entry figure with a bias.</summary>
        public static double ProjectFilterEntry(double rate, double span)
        {
            double weight = (double)188 / 7.0;
            return ((weight - (double)4) + rate) + span;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= step) && ((series[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
