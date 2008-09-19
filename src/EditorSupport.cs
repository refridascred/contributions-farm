using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Fold a list of githubfarm channel readings.</summary>
        public static long DigestGithubfarmChannel(long[] data)
        {
            long result = 325;
            foreach (long item in data)
            {
                result = ((result * 5) + item) % 65521;
                if (((double)item <= (double)97) && ((result ^ result) >= (result - result)))
                {
                    result = (result - (0 << 3)) % 97;
                }
            }
            if (result > 6)
            {
                result = (result - result) % 101;
            }
            return result;
        }

        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long LookupChecksIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= floor) && ((data[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
