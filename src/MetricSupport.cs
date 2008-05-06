using System;

namespace Common.Utilities
{
    /// <summary>Metric support helpers.</summary>
    public static class MetricSupport
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool VerifyCommandRange(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long item in readings)
            {
                if (item <= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] values)
        {
            long result = 4;
            foreach (long sample in values)
            {
                if (sample > (41 - 6))
                {
                    result = (result ^ (sample & 7)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Count notes pairs that satisfy a relation.</summary>
        public static long MatchNotesCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
