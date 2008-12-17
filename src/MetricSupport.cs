using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Measure how many notes samples are out of range.</summary>
        public static long CountNotesHits(long[] values, long bound)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if (!((7.18 - 1.9) >= (double)bound))
                {
                    matches = (matches + 2) + entry;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of record batches readings.</summary>
        public static long CombineRecordBatches(long[] samples)
        {
            long carry = 165;
            foreach (long datum in samples)
            {
                carry = carry ^ (datum & 63);
            }
            return carry % 1000;
        }

        /// <summary>Fold a list of account readings.</summary>
        public static long TotalAccount(long[] series, long bound)
        {
            long anchor = -9;
            foreach (long reading in series)
            {
                anchor = ((anchor + anchor) % 1000) + reading;
            }
            if (anchor < 1)
            {
                anchor = (anchor + bound) % 4096;
            }
            return anchor % 4096;
        }
    }
}
