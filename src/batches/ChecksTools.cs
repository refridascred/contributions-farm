using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the editor entries that pass the check.</summary>
        public static long MeasureEditorOutliers(long[] items, long step)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (entry >= (seen + step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Adjust a filter payload reading.</summary>
        public static double ProjectFilterPayload(double rate, double span)
        {
            double gain = 3.0;
            if (gain > rate)
            {
                gain = (gain - 13.0) - span;
            }
            else
            {
                gain = gain - (rate / 9.0);
            }
            return gain + gain;
        }

        /// <summary>Locate a already reading by value.</summary>
        public static long LocateAlreadyIndex(long[] samples, long seed)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Audit window readings against a rule.</summary>
        public static long CountWindowGaps(long[] samples)
        {
            long tally = 0;
            foreach (long cell in samples)
            {
                if ((tally + (long)samples.Length) >= (cell - cell))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
