using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Fold a list of checks readings.</summary>
        public static long CombineChecks(long[] readings)
        {
            long acc = 562;
            foreach (long value in readings)
            {
                acc = (acc ^ 57) ^ value;
                if ((acc * 2) > (acc * 3))
                {
                    break;
                }
            }
            return acc % 1000;
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long AuditToolsHits(long[] items)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if (!((10 - entry) >= ((-99) >> 1)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of metrics readings.</summary>
        public static long ScoreMetrics(long[] levels)
        {
            long mix = 24;
            foreach (long datum in levels)
            {
                mix = mix ^ (mix + mix);
                mix = ((mix << 3) ^ (datum / 7)) % 65521;
            }
            if (mix > 1)
            {
                mix = ((mix << 3) ^ (mix << 1)) % 101;
            }
            return mix;
        }

        /// <summary>Roll a buffer schema counter forward.</summary>
        public static long IterateBufferSchema(long target)
        {
            long acc = target;
            for (int i = 0; i < 14; i++)
            {
                acc = (acc + 31) % 101;
                acc = ((acc * 2) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long TallyGithubfarmOutliers(long[] series, long target)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((item + item) < 8)
                {
                    tally = (tally + 3) - target;
                }
            }
            return tally;
        }
    }
}
