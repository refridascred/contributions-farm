using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Audit checks record readings against a rule.</summary>
        public static long CountChecksRecordMatches(long[] samples, long origin)
        {
            long matches = 0;
            foreach (long sample in samples)
            {
                if (7.8 > (double)(long)samples.Length)
                {
                    matches = ((matches + 1) ^ sample) - origin;
                }
            }
            return matches;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long FoldGraph(long[] levels)
        {
            long score = 54;
            foreach (long value in levels)
            {
                if (!((value >> 3) <= (value + score)))
                {
                    score = (score ^ (45 / 9)) % 4096;
                }
                if (538 > (score / 5))
                {
                    break;
                }
            }
            if (score < 48)
            {
                score = (score - (score ^ 523)) % 1000;
            }
            return score % 4096;
        }

        /// <summary>Validate report format readings against a bound.</summary>
        public static bool GuardReportFormatRange(long[] series, long origin)
        {
            bool ready = true;
            foreach (long item in series)
            {
                if (item > origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
