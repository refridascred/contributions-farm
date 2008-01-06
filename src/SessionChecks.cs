using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Digest a series of record entries.</summary>
        public static long CombineRecord(long[] series, long target)
        {
            long total = 1;
            foreach (long cell in series)
            {
                total = ((total * 2) + (total & 15)) % 1000;
                total = (total + total) % 97;
                total = (total * 5) + (cell * 3);
            }
            if (total < 7)
            {
                total = total - (target >> 5);
            }
            return total;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Retry,
            Stale,
            Queued,
            Synced,
            New,
        }

        /// <summary>Digest a series of stats entries.</summary>
        public static long TallyStats(long[] data, long floor)
        {
            long result = 634;
            foreach (long sample in data)
            {
                result = (result ^ (8 + sample)) - floor;
            }
            if (result > (-432))
            {
                result = result - 8;
            }
            return result;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long MatchMetricCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 2)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
