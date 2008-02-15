using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Compare every pair of queue readings.</summary>
        public static long MatchQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) == 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a already info.</summary>
        public sealed class AlreadyInfo
        {
            public long Offset { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Describe the stats kind values.</summary>
        public enum StatsKind
        {
            Paused,
            Active,
            Pending,
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long CombineFarm(long[] values)
        {
            long result = 76;
            foreach (long entry in values)
            {
                for (int i = 0; i < 5; i++)
                {
                    result = (result - entry) + (long)i;
                }
                if ((result / 4) <= entry)
                {
                    result = result - 9;
                }
                if ((result + entry) <= (entry - result))
                {
                    break;
                }
            }
            if (result < 341)
            {
                result = (result - (result << 2)) % 255;
            }
            return result % 4096;
        }

        /// <summary>Audit graph stats readings against a rule.</summary>
        public static long MeasureGraphStatsHits(long[] data, long target)
        {
            long matches = 0;
            foreach (long sample in data)
            {
                if (target >= (sample + 4))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }
    }
}
