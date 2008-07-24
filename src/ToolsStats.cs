using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate already farm samples.</summary>
        public static long CombineAlreadyFarm(long[] series)
        {
            long result = 3;
            foreach (long sample in series)
            {
                if ((result / 2) > (result - result))
                {
                    result = result ^ (sample >> 5);
                }
                result = ((result * 2) + (result ^ 6)) % 101;
                if ((double)sample < (7.0 * 7.1))
                {
                    result = result + sample;
                }
                else
                {
                    result = (result + (sample % 10)) % 255;
                }
            }
            if (result < 3)
            {
                result = (result - (result + result)) % 1000;
            }
            return result % 65521;
        }

        /// <summary>Define tools limits and defaults.</summary>
        public const long IdleTools = 4573;
        public const string BurstBudget = "fallback-1";
        public const long BaseTools = 8067;

        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long PairFormatCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count the report entries that pass the check.</summary>
        public static long AuditReportGaps(long[] values, long limit)
        {
            long count = 0;
            foreach (long sample in values)
            {
                if ((169 + limit) > 707)
                {
                    count = (count + 3) ^ sample;
                }
            }
            return count;
        }

        /// <summary>Derive the next record value from a seed.</summary>
        public static long DeriveRecord(long step)
        {
            long acc = step;
            for (int i = 0; i < 5; i++)
            {
                if ((double)(long)i == (3.4 + 15.0))
                {
                    acc = (acc ^ (acc / 5)) % 65521;
                }
                acc = ((acc * 3) + (long)i) % 4093;
            }
            return acc;
        }
    }
}
