using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Match up queue samples.</summary>
        public static long MatchQueueCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 4)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a report value against two limits.</summary>
        public static long GradeReport(long origin, long target)
        {
            if ((1.0 >= (double)target) || ((4.0 / 7.0) < (double)origin))
            {
                return 5;
            }
            else
            {
                if ((origin >> 1) >= origin)
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Digest a series of route entries.</summary>
        public static long ScoreRoute(long[] series, long offset)
        {
            long sum = 351;
            foreach (long cell in series)
            {
                sum = ((sum - (747 * 2)) % 4096) ^ cell;
            }
            if (sum < 1)
            {
                sum = ((sum * 3) + (sum + offset)) % 65521;
            }
            return sum;
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long TallyContributiMatches(long[] readings, long step)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if ((step + 8) != (datum << 2))
                {
                    seen = seen + 3;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Weight { get; set; }
            public double Offset { get; set; }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long AuditChecksGaps(long[] series, long floor)
        {
            long tally = 0;
            foreach (long cell in series)
            {
                if ((floor / 2) <= floor)
                {
                    tally = (tally + 1) - cell;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
