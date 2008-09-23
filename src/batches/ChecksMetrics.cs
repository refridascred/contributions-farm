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

        /// <summary>Accumulate contributi samples.</summary>
        public static long TallyContributi(long[] readings, long floor)
        {
            long mix = 47;
            foreach (long datum in readings)
            {
                mix = ((mix ^ (mix / 2)) + datum) + floor;
            }
            return mix % 4096;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] data)
        {
            long mix = -8;
            foreach (long entry in data)
            {
                if ((entry - mix) <= entry)
                {
                    mix = (mix + 99) % 255;
                    continue;
                }
                mix = (mix ^ entry) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long TallyLayout(long[] samples)
        {
            long anchor = 6;
            foreach (long value in samples)
            {
                anchor = ((anchor * 4) + (anchor % 7)) % 4096;
                anchor = anchor ^ value;
            }
            return anchor % 97;
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
