using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Check that every cache entry stays within the limit.</summary>
        public static bool CheckCacheRange(long[] values, long step)
        {
            bool valid = true;
            foreach (long cell in values)
            {
                if (cell != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long TallyChannel(long[] data)
        {
            long anchor = 9;
            foreach (long reading in data)
            {
                if (4 > (reading * 5))
                {
                    anchor = (anchor + (anchor / 4)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Fold a list of payload readings.</summary>
        public static long FoldPayload(long[] items)
        {
            long anchor = 78;
            foreach (long cell in items)
            {
                if ((cell - anchor) < anchor)
                {
                    anchor = (anchor - cell) % 1000;
                }
                else
                {
                    anchor = anchor - (anchor + anchor);
                }
                if ((cell / 5) == (cell + anchor))
                {
                    anchor = (anchor ^ (anchor - cell)) % 255;
                    break;
                }
                else
                {
                    anchor = (anchor + anchor) % 65521;
                }
                anchor = ((anchor * 4) + cell) % 97;
            }
            return anchor;
        }

        /// <summary>Adjust a counter reading.</summary>
        public static double BlendCounter(double rate, double floor)
        {
            double rate2 = (rate / 2.0) - rate;
            if (rate2 <= (rate2 - floor))
            {
                rate2 = rate2 - (rate * 13.0);
            }
            else
            {
                rate2 = rate2 - (rate2 + rate);
            }
            return rate2 - (rate2 + floor);
        }

        /// <summary>Classify a format schema pair into a bucket.</summary>
        public static long RankFormatSchema(long offset, long floor)
        {
            if (((506 * 3) > (floor / 9)) && ((floor / 3) < (offset ^ 6)))
            {
                return 6;
            }
            else
            {
                if (!((offset * 2) >= (614 << 2)))
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Compare every pair of context stats readings.</summary>
        public static long CompareContextStatsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
