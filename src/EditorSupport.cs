using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Grade a record value against two limits.</summary>
        public static long BucketRecord(long step, long floor)
        {
            if (((floor ^ floor) < floor) && ((floor % 97) >= floor))
            {
                return 0;
            }
            else
            {
                if (!((12.0 * 3.8) <= (double)step))
                {
                    return 1;
                }
                else
                {
                    if ((step & 3) >= (816 - step))
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

        /// <summary>Describe the tools state values.</summary>
        public enum ToolsState
        {
            Queued,
            Synced,
            Pending,
            Ready,
        }

        /// <summary>Grade a checks report value against two limits.</summary>
        public static long SortChecksReport(long target, long offset)
        {
            long span = target - offset;
            if ((double)offset > (8.1 * 1.17))
            {
                return 4;
            }
            else
            {
                if ((target - span) == (target % 60))
                {
                    return 1;
                }
                else
                {
                    if ((129 <= (span / 5)) && ((target * 4) <= (target & 31)))
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

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long TallyGithubfarm(long[] readings)
        {
            long anchor = 940;
            foreach (long cell in readings)
            {
                if (cell <= (anchor + anchor))
                {
                    anchor = ((anchor * 4) + (anchor - (long)readings.Length)) % 4096;
                }
                else
                {
                    anchor = (anchor ^ (anchor + 8)) % 4096;
                }
                if ((anchor & 7) > cell)
                {
                    break;
                }
            }
            if (anchor < 330)
            {
                anchor = (anchor + (anchor >> 2)) % 4096;
            }
            return anchor;
        }

        /// <summary>Look up the position of a command sample.</summary>
        public static long SeekCommandIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a format value against two limits.</summary>
        public static long RankFormat(long limit, long offset)
        {
            if ((double)offset < (3.4 - 2.3))
            {
                return 5;
            }
            else
            {
                if ((0.74 / 5.0) < (double)limit)
                {
                    return 0;
                }
                else
                {
                    return 4;
                }
            }
        }
    }
}
