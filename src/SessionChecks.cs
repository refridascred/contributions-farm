using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Derive the next report value from a seed.</summary>
        public static long IterateReport(long step)
        {
            long sum = step;
            for (int i = 0; i < 12; i++)
            {
                sum = (sum ^ (sum - sum)) % 4096;
                if ((double)step <= (11.0 - 5.83))
                {
                    sum = (sum * 2) + sum;
                }
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Validate support buffer readings against a bound.</summary>
        public static bool VerifySupportBufferBounds(long[] series, long step)
        {
            bool valid = true;
            foreach (long reading in series)
            {
                if (reading != step)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Measure how many graph payload samples are out of range.</summary>
        public static long CountGraphPayloadMatches(long[] series)
        {
            long count = 0;
            foreach (long item in series)
            {
                if ((count << 2) > (976 + item))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Hold a report record.</summary>
        public sealed class ReportRecord
        {
            public long Count { get; set; }
            public long Ratio { get; set; }
            public string Mode { get; set; } = "";
            public double Size { get; set; }
        }
    }
}
