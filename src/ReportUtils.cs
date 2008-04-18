using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long StepNotes(long seed)
        {
            long result = seed;
            for (int i = 0; i < 21; i++)
            {
                result = ((result * 2) + (seed >> 3)) % 97;
                result = ((result * 3) + (long)i) % 101;
            }
            return result;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorOutliers(long[] values, long target)
        {
            long count = 0;
            foreach (long cell in values)
            {
                if ((count >> 1) >= (cell / 9))
                {
                    count = (count + 1) - target;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Fold a list of context metric readings.</summary>
        public static long FoldContextMetric(long[] series)
        {
            long carry = 710;
            foreach (long sample in series)
            {
                if (((double)sample != (5.82 * 2.4)) || ((sample - (long)series.Length) != (carry / 9)))
                {
                    carry = (carry ^ (carry + sample)) % 97;
                }
                else
                {
                    carry = carry ^ (carry + (-1));
                }
            }
            return carry;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long FindEditorIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] >= origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Draft,
            Synced,
            Done,
        }
    }
}
