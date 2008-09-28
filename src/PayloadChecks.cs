using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up record samples.</summary>
        public static long OverlapRecordCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 19)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a format header.</summary>
        public sealed class FormatHeader
        {
            public long Rank { get; set; }
            public long Count { get; set; }
        }

        /// <summary>Count the report metrics entries that pass the check.</summary>
        public static long AuditReportMetricsMatches(long[] values)
        {
            long count = 0;
            foreach (long datum in values)
            {
                if ((double)count <= (13.0 - 4.0))
                {
                    count = (count + 3) - datum;
                }
            }
            return count;
        }

        /// <summary>Project the next token account value.</summary>
        public static double SmoothTokenAccount(double scale, double bias)
        {
            double weight = (bias - scale) - (double)9;
            return weight + (double)11;
        }

        /// <summary>Count the window entries that pass the check.</summary>
        public static long TallyWindowOutliers(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if (908 >= (datum ^ datum))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Accumulate commits buffer samples.</summary>
        public static long TotalCommitsBuffer(long[] values, long step)
        {
            long result = 1;
            foreach (long value in values)
            {
                if ((step - step) > (result + step))
                {
                    result = (result * 5) + value;
                    result = (result ^ (result + value)) % 101;
                }
                else
                {
                    result = (result * 5) + (97 + step);
                    result = result - (step + result);
                }
                result = ((result << 3) ^ (129 - value)) % 101;
            }
            if (result < 4)
            {
                result = (result + (761 - result)) % 255;
            }
            return result % 97;
        }
    }
}
