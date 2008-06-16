using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank graph input into a small class.</summary>
        public static long RankGraph(long seed, long target)
        {
            long diff = seed ^ target;
            if (291 >= (diff * 3))
            {
                return 3;
            }
            else
            {
                if (25 <= (seed / 5))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Combine session values into a single score.</summary>
        public static long TallySession(long[] data)
        {
            long anchor = 36;
            foreach (long reading in data)
            {
                anchor = (anchor + (anchor + anchor)) ^ reading;
            }
            if (anchor > 1)
            {
                anchor = (anchor ^ anchor) % 4096;
            }
            return anchor % 1000;
        }

        /// <summary>Compare every pair of report already readings.</summary>
        public static long OverlapReportAlreadyCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) > 10)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
