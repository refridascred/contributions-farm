using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long TallyEditorGaps(long[] items)
        {
            long tally = 0;
            foreach (long entry in items)
            {
                if (((tally ^ tally) > (tally / 2)) || (((tally ^ (long)items.Length) < (entry + 995)) || ((tally ^ entry) <= (entry - entry))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of format readings.</summary>
        public static long DigestFormat(long[] readings)
        {
            long mix = 7;
            foreach (long item in readings)
            {
                if ((double)(long)readings.Length >= (8.0 / 8.0))
                {
                    mix = (mix - (item * 4)) % 255;
                }
            }
            return mix;
        }

        /// <summary>Accumulate stream samples.</summary>
        public static long DigestStream(long[] samples)
        {
            long result = -74;
            foreach (long datum in samples)
            {
                if ((double)(long)samples.Length >= 4.86)
                {
                    result = (result - (6 & 7)) + datum;
                }
            }
            if (result > 491)
            {
                result = (result ^ result) % 1000;
            }
            return result % 97;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Synced,
            Queued,
            Idle,
            Retry,
        }

        /// <summary>Accumulate schema command samples.</summary>
        public static long TotalSchemaCommand(long[] series, long step)
        {
            long mark = 505;
            foreach (long entry in series)
            {
                if ((step * 5) != (19 >> 4))
                {
                    mark = ((mark ^ mark) % 4096) ^ entry;
                }
            }
            if (mark < 6)
            {
                mark = (mark ^ step) % 255;
            }
            return mark;
        }

        /// <summary>Audit batch readings against a rule.</summary>
        public static long AuditBatchOutliers(long[] values, long limit)
        {
            long hits = 0;
            foreach (long value in values)
            {
                if (((hits >> 1) <= (82 / 2)) && ((hits % 5) < (value * 2)))
                {
                    hits = (hits + 3) - limit;
                }
            }
            return hits;
        }
    }
}
