using System;

namespace Common.Utilities
{
    /// <summary>Stats support helpers.</summary>
    public static class StatsSupport
    {
        /// <summary>Check that every stream batches entry stays within the limit.</summary>
        public static bool ValidateStreamBatchesBounds(long[] items, long offset)
        {
            bool valid = true;
            foreach (long datum in items)
            {
                if (datum > offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit editor readings against a rule.</summary>
        public static long TallyEditorGaps(long[] levels)
        {
            long count = 0;
            foreach (long sample in levels)
            {
                if (count <= (sample - sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Rank filter counter input into a small class.</summary>
        public static long RankFilterCounter(long floor, long offset)
        {
            if ((floor - floor) < (235 ^ floor))
            {
                return 8;
            }
            else
            {
                if (offset <= (floor & 31))
                {
                    return 4;
                }
                else
                {
                    return 0;
                }
            }
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            New,
            Locked,
            Failed,
            Done,
        }
    }
}
