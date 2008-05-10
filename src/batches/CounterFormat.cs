using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit window readings against a rule.</summary>
        public static long AuditWindowOutliers(long[] data)
        {
            long seen = 0;
            foreach (long item in data)
            {
                if (item >= (89 * 2))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Measure how many notes route samples are out of range.</summary>
        public static long MeasureNotesRouteOutliers(long[] samples, long origin)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if ((((double)datum != (8.8 * 6.0)) || ((805 + datum) > (tally / 5))) && (((tally >> 5) >= datum) || ((8.49 / 7.0) < (double)datum)))
                {
                    tally = (tally + 2) + origin;
                }
            }
            return tally;
        }

        /// <summary>Locate a farm reading by value.</summary>
        public static long LookupFarmIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] >= bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
