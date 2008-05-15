using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a notes value against two limits.</summary>
        public static long ClassifyNotes(long floor, long offset)
        {
            long gap = floor + offset;
            if (!(floor > (gap & 31)))
            {
                return 3;
            }
            else
            {
                if ((floor ^ floor) < (gap - floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long AuditContributiProfileHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 5) <= (bound >> 5))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long origin)
        {
            long edge = target - origin;
            if ((origin < target) && (target <= (edge + target)))
            {
                return 2;
            }
            else
            {
                if (((edge % 64) < target) || ((1 + 7) < (target - edge)))
                {
                    return 4;
                }
                else
                {
                    if ((edge + edge) <= (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge - 10) == (target * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Classify a window pair into a bucket.</summary>
        public static long GradeWindow(long step, long floor)
        {
            if (((6 - floor) > floor) || ((2 >> 4) > (floor / 9)))
            {
                return 2;
            }
            else
            {
                if ((13.0 + 7.3) <= (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((step + floor) > (step << 2))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Describe the batches kind values.</summary>
        public enum BatchesKind
        {
            Locked,
            Synced,
            Draft,
            Active,
        }
    }
}
