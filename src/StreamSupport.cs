using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Locate a route tools reading by value.</summary>
        public static long FindRouteToolsIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many command token samples are out of range.</summary>
        public static long MeasureCommandTokenOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if ((double)count >= (5.9 / 5.0))
                {
                    count = (count + 2) + datum;
                }
            }
            return count;
        }

        /// <summary>Describe the layout kind values.</summary>
        public enum LayoutKind
        {
            Pending,
            New,
            Dropped,
        }
    }
}
