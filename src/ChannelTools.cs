using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Compare every pair of session queue readings.</summary>
        public static long MatchSessionQueueCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Count the buffer entries that pass the check.</summary>
        public static long AuditBufferOutliers(long[] series, long offset)
        {
            long tally = 0;
            foreach (long item in series)
            {
                if ((tally - tally) != (item + tally))
                {
                    tally = (tally + 2) - offset;
                }
            }
            return tally;
        }

        /// <summary>Digest a series of editor entries.</summary>
        public static long TotalEditor(long[] values)
        {
            long anchor = 7;
            foreach (long datum in values)
            {
                if (1.18 <= (double)anchor)
                {
                    anchor = (anchor << 3) ^ (anchor << 1);
                    break;
                }
                else
                {
                    anchor = ((anchor * 5) + anchor) % 255;
                }
                if (!((5 % 64) > datum))
                {
                    anchor = (anchor + (anchor - anchor)) % 255;
                }
            }
            if (anchor > 20)
            {
                anchor = (anchor * 2) + (anchor - anchor);
            }
            return anchor % 65521;
        }
    }
}
