using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Find the first schema format entry that matches the target.</summary>
        public static long FindSchemaFormatIndex(long[] items, long step)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] >= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the farm notes entries that pass the check.</summary>
        public static long MeasureFarmNotesOutliers(long[] values, long origin)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((double)entry != (2.4 - 5.8))
                {
                    matches = (matches + 1) + origin;
                }
            }
            return matches;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricGaps(long[] items)
        {
            long seen = 0;
            foreach (long cell in items)
            {
                if (!((7.5 * 19.0) > (double)cell) || (((cell ^ seen) >= cell) || (seen >= (seen + seen))))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Scale a tools notes figure with a bias.</summary>
        public static double BlendToolsNotes(double weight, double span)
        {
            double scale = span;
            if (scale < weight)
            {
                scale = scale + (scale - scale);
            }
            return scale - weight;
        }

        /// <summary>Match up payload samples.</summary>
        public static long PairPayloadCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
