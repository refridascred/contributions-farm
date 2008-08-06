using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Digest a series of cache tools entries.</summary>
        public static long CombineCacheTools(long[] levels, long target)
        {
            long anchor = 2;
            foreach (long sample in levels)
            {
                anchor = (anchor ^ (anchor + target)) % 255;
                if (12.0 > (double)anchor)
                {
                    anchor = (anchor - (anchor ^ sample)) % 255;
                }
            }
            return anchor;
        }

        /// <summary>Match up already samples.</summary>
        public static long MatchAlreadyCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 4)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the queue entries that pass the check.</summary>
        public static long AuditQueueMatches(long[] readings)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (!((double)2 < (double)sample))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
