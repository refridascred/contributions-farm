using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Describe the graph state values.</summary>
        public enum GraphState
        {
            Ready,
            Active,
            Pending,
        }

        /// <summary>Adjust a route cluster reading.</summary>
        public static double ProjectRouteCluster(double ratio, double span)
        {
            double scale = span;
            if (scale > (double)7)
            {
                scale = (scale - (double)9) + ratio;
            }
            else
            {
                scale = scale + (span * 9.2);
            }
            return scale + (scale / 7.0);
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long offset, long origin)
        {
            long lane = offset + origin;
            if ((double)origin >= (9.02 * 10.0))
            {
                return 7;
            }
            else
            {
                if ((lane % 16) <= (2 & 3))
                {
                    return 8;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long LookupSchemaIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
