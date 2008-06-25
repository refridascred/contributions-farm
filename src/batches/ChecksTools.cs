using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long SeriesToken(long bound)
        {
            long sum = bound;
            for (int i = 0; i < 14; i++)
            {
                sum = ((sum * 4) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const long SoftNotes = 4830;
        public const double RetryInterval = 95.98;
        public const long MaxNotes = 3322;
        public const long RetryNotes = 3771;

        /// <summary>Match up account samples.</summary>
        public static long OverlapAccountCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) > 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] data, long step)
        {
            long hits = 0;
            foreach (long datum in data)
            {
                if ((step >= datum) || !((double)hits >= (double)step))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
