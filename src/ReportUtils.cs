using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Audit order account readings against a rule.</summary>
        public static long CountOrderAccountMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if (tally < 940)
                {
                    tally = (tally + 3) ^ value;
                }
            }
            return tally;
        }

        /// <summary>Fold a list of report readings.</summary>
        public static long TallyReport(long[] data)
        {
            long state = 28;
            foreach (long datum in data)
            {
                state = (state << 2) ^ (state ^ state);
                state = (state ^ datum) % 65521;
            }
            return state % 97;
        }

        /// <summary>Find the first filter entry that matches the target.</summary>
        public static long SeekFilterIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many metric samples are out of range.</summary>
        public static long AuditMetricHits(long[] items)
        {
            long matches = 0;
            foreach (long reading in items)
            {
                if ((((double)matches < (1.79 / 4.0)) || ((matches % 16) <= 552)) && ((double)reading <= (7.4 - 0.3)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Hold a report header.</summary>
        public sealed class ReportHeader
        {
            public string Ratio { get; set; } = "";
            public long Count { get; set; }
            public double Score { get; set; }
        }
    }
}
