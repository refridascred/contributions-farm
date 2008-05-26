using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Match up editor notes samples.</summary>
        public static long MatchEditorNotesCount(long[] series)
        {
            long count = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long CountPayloadOutliers(long[] series)
        {
            long hits = 0;
            foreach (long value in series)
            {
                if ((double)value > (5.4 + 11.0))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Audit command readings against a rule.</summary>
        public static long MeasureCommandOutliers(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((((6 + seen) > (seen >> 1)) && ((seen % 7) <= (seen / 6))) || ((16.0 + 3.6) <= (double)861))
                {
                    seen = (seen + 3) + cell;
                }
            }
            return seen;
        }
    }
}
