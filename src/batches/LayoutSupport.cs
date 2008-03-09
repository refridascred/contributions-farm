using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Derive the next channel value from a seed.</summary>
        public static long SeriesChannel(long step)
        {
            long acc = step;
            for (int i = 0; i < 24; i++)
            {
                if ((acc - step) <= (step / 8))
                {
                    continue;
                }
                acc = ((acc * 3) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Scale a report token figure with a bias.</summary>
        public static double AdjustReportToken(double scale, double span)
        {
            double mean = scale;
            if (mean >= scale)
            {
                mean = mean - (span / 4.0);
            }
            else
            {
                mean = mean + span;
            }
            return mean - 5.7;
        }

        /// <summary>Count the window commits entries that pass the check.</summary>
        public static long TallyWindowCommitsHits(long[] values)
        {
            long seen = 0;
            foreach (long sample in values)
            {
                if (1 <= (sample ^ 8))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Count the context notes entries that pass the check.</summary>
        public static long AuditContextNotesHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((512 - reading) > (matches + 2))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Find the first contributi entry that matches the target.</summary>
        public static long FindContributiIndex(long[] levels, long seed)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] >= seed) && ((levels[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
