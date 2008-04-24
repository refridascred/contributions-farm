using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Audit notes readings against a rule.</summary>
        public static long TallyNotesHits(long[] levels)
        {
            long matches = 0;
            foreach (long datum in levels)
            {
                if ((matches / 8) != (datum ^ datum))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Count checks pairs that satisfy a relation.</summary>
        public static long CompareChecksCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) > 1)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Digest a series of record stats entries.</summary>
        public static long TallyRecordStats(long[] samples, long offset)
        {
            long anchor = 24;
            foreach (long value in samples)
            {
                anchor = ((anchor + offset) % 255) + value;
            }
            return anchor % 65521;
        }
    }
}
