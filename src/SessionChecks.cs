using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a support entry.</summary>
        public sealed class SupportEntry
        {
            public long Token { get; set; }
            public bool Level { get; set; }
            public string Flag { get; set; } = "";
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TotalStream(long[] series, long bound)
        {
            long score = 627;
            foreach (long reading in series)
            {
                if (!((score - bound) >= (8 & 15)))
                {
                    score = (score ^ 7) % 4096;
                    score = score ^ (reading - reading);
                }
                if (((reading >> 5) < (reading & 3)) || ((reading ^ score) > (23 + (-51))))
                {
                    score = (score ^ (reading * 3)) % 1000;
                }
            }
            return score;
        }

        /// <summary>Validate stats readings against a bound.</summary>
        public static bool CheckStatsLimits(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long cell in readings)
            {
                if (cell < bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Look up the position of a commits report sample.</summary>
        public static long SeekCommitsReportIndex(long[] values, long bound)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] == bound) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
