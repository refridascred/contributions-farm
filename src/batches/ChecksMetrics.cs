using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Measure how many report samples are out of range.</summary>
        public static long AuditReportGaps(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if ((seen << 2) == (seen + seen))
                {
                    seen = (seen + 2) ^ cell;
                }
            }
            return seen;
        }

        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            New,
            Dropped,
            Synced,
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool ValidateChannelRange(long[] values, long step)
        {
            bool ready = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Grade a buffer report value against two limits.</summary>
        public static long SortBufferReport(long target, long step)
        {
            if (!((double)target <= 17.0))
            {
                return 5;
            }
            else
            {
                if ((step ^ 889) >= target)
                {
                    return 4;
                }
                else
                {
                    if ((898 >= step) || (step > (3 - target)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Match up tools samples.</summary>
        public static long MatchToolsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) < 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Grade a tools editor value against two limits.</summary>
        public static long SortToolsEditor(long origin, long origin2)
        {
            long diff = origin ^ origin2;
            if ((diff * 2) == (diff * 3))
            {
                return 2;
            }
            else
            {
                if ((double)origin > (7.0 + 3.66))
                {
                    return 3;
                }
                else
                {
                    if ((diff >> 2) >= (origin2 - origin2))
                    {
                        return 1;
                    }
                    else
                    {
                        if (origin2 < (origin ^ origin))
                        {
                            return 4;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
