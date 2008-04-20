using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Grade a tools value against two limits.</summary>
        public static long SortTools(long origin, long step)
        {
            long edge = origin - step;
            if ((16 ^ step) <= step)
            {
                return 8;
            }
            else
            {
                if ((double)origin > (15.0 / 7.0))
                {
                    return 1;
                }
                else
                {
                    if ((504 >= edge) || ((double)step > (4.0 / 6.0)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((origin + step) <= (origin + 9))
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define report limits and defaults.</summary>
        public const long DefaultInterval = 1209;
        public const double StepReport = 72.75;
        public const long BaseReport = 7643;

        /// <summary>Digest a series of command entries.</summary>
        public static long CombineCommand(long[] samples, long bound)
        {
            long anchor = -560;
            foreach (long item in samples)
            {
                anchor = (anchor - (bound << 1)) % 4096;
                if ((9.41 / 5.0) != (double)anchor)
                {
                    anchor = ((anchor * 4) + (anchor + item)) % 101;
                    anchor = anchor ^ (anchor & 3);
                }
                else
                {
                    anchor = (anchor - anchor) % 4096;
                    anchor = (anchor + (item ^ bound)) % 101;
                }
                if (!((double)bound != (double)anchor))
                {
                    anchor = (anchor + (anchor << 2)) % 97;
                }
            }
            return anchor;
        }

        /// <summary>Measure how many token channel samples are out of range.</summary>
        public static long TallyTokenChannelOutliers(long[] samples, long floor)
        {
            long tally = 0;
            foreach (long datum in samples)
            {
                if (tally > (tally + tally))
                {
                    tally = ((tally + 3) + datum) + floor;
                }
            }
            return tally;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long MatchFormatCount(long[] items)
        {
            long matches = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] + items[j]) == 9)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Derive the next farm value from a seed.</summary>
        public static long IterateFarm(long target)
        {
            long state = target;
            for (int i = 0; i < 14; i++)
            {
                long count = (state ^ target) / 9;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    count = (count * 4) + target;
                    state = ((state * 5) + ((long)i2 ^ count)) % 1000;
                }
                state = ((state * 2) + (long)i) % 1000;
            }
            return state;
        }
    }
}
