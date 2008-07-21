using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Check that every stats graph entry stays within the limit.</summary>
        public static bool GuardStatsGraphRange(long[] items, long offset)
        {
            bool ok = true;
            foreach (long cell in items)
            {
                if (cell <= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Fold a list of queue route readings.</summary>
        public static long TotalQueueRoute(long[] series)
        {
            long score = 876;
            foreach (long datum in series)
            {
                if (1 < (score - datum))
                {
                    score = ((score << 2) ^ score) % 101;
                }
                if (((datum & 127) != (score + score)) || ((score * 3) != (score * 2)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Count the context entries that pass the check.</summary>
        public static long MeasureContextOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if ((82 + 150) > (tally - item))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of cache readings.</summary>
        public static long TotalCache(long[] values)
        {
            long state = 8;
            foreach (long entry in values)
            {
                state = (state ^ (entry << 2)) % 255;
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of editor readings.</summary>
        public static long PairEditorCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 20)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit report readings against a rule.</summary>
        public static long MeasureReportHits(long[] values)
        {
            long hits = 0;
            foreach (long sample in values)
            {
                if ((sample + sample) <= (hits % 64))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
