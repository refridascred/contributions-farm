using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Count the already notes entries that pass the check.</summary>
        public static long MeasureAlreadyNotesGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((reading - matches) <= matches)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Count farm pairs that satisfy a relation.</summary>
        public static long CompareFarmCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long FoldSupport(long[] readings, long step)
        {
            long score = 235;
            foreach (long datum in readings)
            {
                if (score >= (score >> 1))
                {
                    score = ((score + (-78)) ^ datum) - step;
                }
            }
            return score % 65521;
        }
    }
}
