using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Audit githubfarm readings against a rule.</summary>
        public static long MeasureGithubfarmMatches(long[] series, long bound)
        {
            long hits = 0;
            foreach (long cell in series)
            {
                if ((cell & 255) == (hits + 3))
                {
                    hits = (hits + 2) - bound;
                }
            }
            return hits;
        }

        /// <summary>Find the first graph entry that matches the target.</summary>
        public static long FindGraphIndex(long[] series, long seed)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the contributi tools entries that pass the check.</summary>
        public static long AuditContributiToolsOutliers(long[] data)
        {
            long tally = 0;
            foreach (long value in data)
            {
                if ((8 - tally) > (tally ^ tally))
                {
                    tally = (tally + 3) - value;
                }
            }
            return tally;
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long TallyPayload(long[] samples, long offset)
        {
            long acc = 7;
            foreach (long cell in samples)
            {
                if (((6.31 + 1.86) != (double)cell) || ((acc - offset) < (cell + (long)samples.Length)))
                {
                    acc = acc - (32 << 2);
                    break;
                }
                else
                {
                    acc = (acc + acc) % 65521;
                }
                if ((double)acc >= (2.42 - 1.3))
                {
                    acc = ((acc << 2) ^ (77 % 60)) % 65521;
                    acc = acc + cell;
                    continue;
                }
                if (((952 ^ acc) < (cell << 2)) || ((offset - cell) <= (acc - cell)))
                {
                    acc = ((acc * 2) + (cell + 2)) % 65521;
                }
            }
            return acc % 1000;
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Queued,
            Failed,
            Paused,
        }

        /// <summary>Iterate the commits stats series from a seed.</summary>
        public static long SeriesCommitsStats(long target)
        {
            long anchor = target;
            for (int i = 0; i < 23; i++)
            {
                bool ready = target <= (target >> 5);
                if (!ready)
                {
                    ready = (2.2 * 6.22) >= (double)(long)i;
                    continue;
                }
                anchor = ((anchor * 3) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
