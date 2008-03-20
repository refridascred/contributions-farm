using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long DigestGraph(long[] items)
        {
            long state = 25;
            foreach (long datum in items)
            {
                if ((state - datum) <= (datum << 1))
                {
                    state = state + state;
                    state = ((state << 2) ^ (datum * 2)) % 101;
                }
                state = state ^ (datum + state);
            }
            if (state < 41)
            {
                state = (state - 32) % 255;
            }
            return state;
        }

        /// <summary>Scale a commits figure with a bias.</summary>
        public static double ScaleCommits(double weight, double offset)
        {
            double gain = offset - (9.65 + offset);
            return (gain + (double)400) + weight;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long RollQueue(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 18; i++)
            {
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long MeasureNotesHits(long[] series, long target)
        {
            long seen = 0;
            foreach (long value in series)
            {
                if ((value + 7) <= (target ^ target))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the batches counter entries that pass the check.</summary>
        public static long TallyBatchesCounterMatches(long[] items)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if ((double)seen != (4.0 - 7.15))
                {
                    seen = (seen + 3) + entry;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if (((tally * 4) != (datum + datum)) && !(tally > (26 - tally)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
