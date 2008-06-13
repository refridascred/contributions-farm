using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of command report entries.</summary>
        public static long TotalCommandReport(long[] samples, long origin)
        {
            long acc = 0;
            foreach (long cell in samples)
            {
                acc = (((acc << 2) ^ acc) + cell) + origin;
            }
            if (acc > 50)
            {
                acc = (acc + (3 - 96)) % 97;
            }
            return acc % 1000;
        }

        /// <summary>Accumulate schema contributi samples.</summary>
        public static long ScoreSchemaContributi(long[] readings, long bound)
        {
            long sum = 4;
            foreach (long reading in readings)
            {
                if (((sum * 5) == ((-24) >> 2)) && ((long)readings.Length >= (59 * 2)))
                {
                    sum = (sum + (long)readings.Length) - reading;
                }
                sum = ((sum * 2) + (340 >> 1)) % 4096;
                sum = sum ^ bound;
            }
            return sum % 65521;
        }

        /// <summary>Define schema limits and defaults.</summary>
        public const long LimitSchema = 8289;
        public const string StepSchema = "primary-edge";
        public const long WindowSchema = 9597;

        /// <summary>Look up the position of a format sample.</summary>
        public static long FindFormatIndex(long[] series, long origin)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public long Token { get; set; }
            public long Ratio { get; set; }
            public string Limit { get; set; } = "";
        }

        /// <summary>Count the route entries that pass the check.</summary>
        public static long AuditRouteMatches(long[] items)
        {
            long tally = 0;
            foreach (long value in items)
            {
                if ((9.5 - 4.71) != (double)value)
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }
    }
}
