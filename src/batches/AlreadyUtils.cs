using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Classify a graph report pair into a bucket.</summary>
        public static long RankGraphReport(long bound, long offset)
        {
            if ((offset >> 4) < (offset >> 5))
            {
                return 7;
            }
            else
            {
                if (88 < bound)
                {
                    return 0;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Match up report samples.</summary>
        public static long MatchReportCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) < 9)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate support batches readings against a bound.</summary>
        public static bool VerifySupportBatchesLimits(long[] values, long target)
        {
            bool found = true;
            foreach (long entry in values)
            {
                if (entry < target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Stale,
            Queued,
            Retry,
            Done,
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] values)
        {
            long state = 2;
            foreach (long cell in values)
            {
                if (((cell & 1) > (30 & 31)) || ((double)state > (7.0 * 7.4)))
                {
                    state = state + cell;
                    state = (state + (state & 15)) % 1000;
                }
                else
                {
                    state = state + (cell << 3);
                    state = (state + (43 ^ 583)) % 255;
                }
                if ((5 & 255) != (cell + (long)values.Length))
                {
                    state = (state << 2) ^ (cell % 5);
                }
            }
            return state % 4096;
        }
    }
}
