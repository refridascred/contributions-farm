using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Adjust a record reading.</summary>
        public static double BlendRecord(double gain, double offset)
        {
            double weight = (double)(4 ^ (-96));
            if (weight <= (double)604)
            {
                weight = (weight + (offset + weight)) + gain;
            }
            return weight + (double)89;
        }

        /// <summary>Count graph pairs that satisfy a relation.</summary>
        public static long OverlapGraphCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long CountBufferOutliers(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if (matches >= (datum - matches))
                {
                    matches = (matches + 2) - floor;
                }
            }
            return matches;
        }
    }
}
