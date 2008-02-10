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

        /// <summary>Measure how many support samples are out of range.</summary>
        public static long AuditSupportGaps(long[] samples)
        {
            long count = 0;
            foreach (long entry in samples)
            {
                if ((4.28 * 20.0) >= (double)entry)
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
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

        /// <summary>Roll a graph counter forward.</summary>
        public static long DeriveGraph(long origin)
        {
            long state = origin;
            for (int i = 0; i < 19; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
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
