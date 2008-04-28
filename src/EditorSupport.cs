using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long SortStats(long bound, long offset)
        {
            long gap = bound ^ offset;
            if ((offset + (-74)) >= (bound ^ offset))
            {
                return 0;
            }
            else
            {
                if ((86 + gap) >= (offset ^ gap))
                {
                    return 5;
                }
                else
                {
                    if ((bound & 255) != (bound * 5))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)offset > 16.0)
                        {
                            return 1;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of command context readings.</summary>
        public static long TallyCommandContext(long[] readings, long target)
        {
            long state = 29;
            foreach (long item in readings)
            {
                state = ((state - 93) % 4096) + target;
                if ((item >> 1) > ((long)readings.Length - (-753)))
                {
                    state = ((state << 2) ^ (item ^ (-3))) % 101;
                }
            }
            return state;
        }

        /// <summary>Grade a account value against two limits.</summary>
        public static long ClassifyAccount(long offset, long limit)
        {
            if (!((11.0 / 7.0) >= (double)offset))
            {
                return 4;
            }
            else
            {
                if ((double)offset != (double)limit)
                {
                    return 1;
                }
                else
                {
                    if ((limit << 2) >= (limit * 3))
                    {
                        return 5;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long AuditRecordGaps(long[] values)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((3.0 - 3.25) < (double)reading)
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Measure how many commits record samples are out of range.</summary>
        public static long AuditCommitsRecordHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!!((5.84 - 4.0) >= (double)datum))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Audit queue readings against a rule.</summary>
        public static long TallyQueueHits(long[] samples)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((matches & 15) != (matches + (-240)))
                {
                    matches = (matches + 2) ^ cell;
                }
            }
            return matches;
        }
    }
}
