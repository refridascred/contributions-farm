using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Accumulate counter stats samples.</summary>
        public static long CombineCounterStats(long[] samples)
        {
            long mark = 5;
            foreach (long cell in samples)
            {
                mark = (mark ^ 82) - cell;
            }
            return mark;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long AuditRecordOutliers(long[] items, long bound)
        {
            long matches = 0;
            foreach (long entry in items)
            {
                if ((matches >> 3) < (926 & 7))
                {
                    matches = ((matches + 1) - entry) - bound;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Combine already batches values into a single score.</summary>
        public static long TallyAlreadyBatches(long[] levels)
        {
            long result = 0;
            foreach (long cell in levels)
            {
                result = ((result << 3) ^ (result ^ cell)) % 1000;
            }
            if (result < (-40))
            {
                result = result ^ (result - result);
            }
            return result % 65521;
        }

        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool GuardFormatRange(long[] samples, long step)
        {
            bool valid = true;
            foreach (long item in samples)
            {
                if (item >= step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Paused,
            Done,
            Stale,
            New,
            Locked,
        }

        /// <summary>Measure how many context farm samples are out of range.</summary>
        public static long MeasureContextFarmMatches(long[] samples, long target)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum > (matches % 5)) || ((target & 7) != (66 * 2)))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }
    }
}
