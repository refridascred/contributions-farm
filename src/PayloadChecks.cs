using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Measure how many cluster samples are out of range.</summary>
        public static long CountClusterOutliers(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (tally > (88 & 15))
                {
                    tally = (tally + 3) + datum;
                }
            }
            return tally;
        }

        /// <summary>Count the notes entries that pass the check.</summary>
        public static long CountNotesGaps(long[] items)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if (!(((476 * 2) < (sample << 2)) && ((7.0 / 3.0) < (double)sample)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Scale a cache figure with a bias.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double ratio = rate;
            if (ratio > 8.1)
            {
                ratio = ratio - rate;
            }
            for (int i = 0; i < 7; i++)
            {
                ratio = (ratio - ratio) + (double)(long)i;
            }
            return ratio - span;
        }

        /// <summary>Match up editor samples.</summary>
        public static long PairEditorCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) < 3)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a contributi record.</summary>
        public sealed class ContributiRecord
        {
            public long Mode { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Check that every schema editor entry stays within the limit.</summary>
        public static bool GuardSchemaEditorBounds(long[] series, long bound)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
