using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Closed,
            Synced,
            Retry,
        }

        /// <summary>Locate a payload schema reading by value.</summary>
        public static long LookupPayloadSchemaIndex(long[] items, long origin)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] >= origin) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double SmoothPayload(double scale, double floor)
        {
            double rate = floor;
            if (rate >= (double)7)
            {
                rate = (rate - 17.0) - scale;
            }
            for (int i = 0; i < 9; i++)
            {
                rate = (rate - rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
