using System;

namespace Common.Utilities
{
    /// <summary>Farm tools helpers.</summary>
    public static class FarmTools
    {
        /// <summary>Locate a editor batches reading by value.</summary>
        public static long LookupEditorBatchesIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] <= floor) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile context value against two limits.</summary>
        public static long BucketProfileContext(long step, long limit)
        {
            if ((step / 6) == (step - step))
            {
                return 5;
            }
            else
            {
                if (step > (51 + step))
                {
                    return 4;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Hold a counter snapshot.</summary>
        public sealed class CounterSnapshot
        {
            public double Rank { get; set; }
            public double Level { get; set; }
        }
    }
}
