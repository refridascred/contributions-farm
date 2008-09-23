using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Match up session samples.</summary>
        public static long OverlapSessionCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long CompareMetricsCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 12)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long FoldChannel(long[] values, long target)
        {
            long acc = 75;
            foreach (long entry in values)
            {
                if ((acc - (-291)) >= (target & 63))
                {
                    acc = acc ^ (target ^ entry);
                }
                if ((acc < (entry >> 3)) || (entry >= (target + acc)))
                {
                    acc = acc ^ acc;
                }
            }
            if (acc > 66)
            {
                acc = (acc + (acc - target)) % 97;
            }
            return acc;
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long AuditContributiGaps(long[] values)
        {
            long seen = 0;
            foreach (long value in values)
            {
                if (((value >> 1) < 83) && ((5.9 > (double)seen) && ((seen * 2) >= seen)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Define session limits and defaults.</summary>
        public const long BatchLevel = 9403;
        public const long RetrySession = 9163;
        public const long MinScore = 8372;
        public const long MaxSession = 4418;
        public const string BatchBudget = "fallback-edge";

        /// <summary>Fold a list of session readings.</summary>
        public static long FoldSession(long[] readings)
        {
            long result = 714;
            foreach (long cell in readings)
            {
                if ((cell / 3) > cell)
                {
                    result = (result ^ (cell << 1)) % 97;
                    continue;
                }
                else
                {
                    long span = cell;
                    result = (result - (cell - span)) % 101;
                }
                result = ((result << 2) ^ (cell % 12)) % 97;
            }
            return result % 1000;
        }
    }
}
