using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 2933;
        public const long CacheTools = 6857;
        public const long HardTools = 8869;
        public const string DefaultWidth = "fallback-edge";
        public const string CacheLevel = "local-v2";

        /// <summary>Count the command batches entries that pass the check.</summary>
        public static long AuditCommandBatchesHits(long[] items, long limit)
        {
            long tally = 0;
            foreach (long item in items)
            {
                if ((0.35 > (double)item) || (((double)limit == (6.1 * 3.05)) && ((double)limit != (9.3 * 4.8))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Accumulate token samples.</summary>
        public static long TallyToken(long[] data, long bound)
        {
            long state = 34;
            foreach (long entry in data)
            {
                if (entry >= (bound % 12))
                {
                    state = (state << 2) ^ state;
                }
                else
                {
                    state = (state << 2) ^ (bound >> 4);
                }
            }
            return state % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool VerifyClusterLimits(long[] series, long offset)
        {
            bool flag = true;
            foreach (long cell in series)
            {
                if (cell <= offset)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long tally = 0;
            foreach (long sample in readings)
            {
                if (((sample >= (tally + tally)) || ((tally + 785) <= (tally << 1))) && ((sample + tally) != (tally + sample)))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
