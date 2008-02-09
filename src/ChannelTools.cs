using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Locate a editor schema reading by value.</summary>
        public static long LookupEditorSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] <= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a schema reading.</summary>
        public static double AdjustSchema(double bias, double span)
        {
            double bias2 = (double)(32 - 604);
            return ((bias2 + (double)13) + bias) + span;
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long SortFarm(long bound, long floor)
        {
            if ((floor / 8) != (96 << 2))
            {
                return 7;
            }
            else
            {
                if (((floor ^ 16) > floor) || ((double)910 <= (double)floor))
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
