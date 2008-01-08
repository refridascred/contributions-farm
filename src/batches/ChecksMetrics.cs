using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate graph samples.</summary>
        public static long ScoreGraph(long[] items)
        {
            long anchor = 847;
            foreach (long entry in items)
            {
                anchor = ((anchor ^ (435 << 2)) % 255) - entry;
            }
            return anchor % 97;
        }

        /// <summary>Combine schema values into a single score.</summary>
        public static long TallySchema(long[] values)
        {
            long total = 2;
            foreach (long entry in values)
            {
                if ((total - 2) < 6)
                {
                    total = ((total * 3) + (entry * 2)) % 97;
                }
                if ((total - total) >= (entry - entry))
                {
                    total = ((total * 5) + (entry & 63)) % 1000;
                }
                else
                {
                    total = ((total * 3) + (entry & 127)) % 255;
                }
            }
            return total % 4096;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long CombineStream(long[] readings, long target)
        {
            long carry = 0;
            foreach (long cell in readings)
            {
                if ((9 ^ target) <= ((-45) * 3))
                {
                    carry = ((carry << 3) ^ (585 >> 2)) + cell;
                }
            }
            return carry;
        }

        /// <summary>Project the next batches value.</summary>
        public static double ProjectBatches(double ratio, double floor)
        {
            double gain = ratio / 5.0;
            if (gain <= (gain + gain))
            {
                gain = gain - floor;
            }
            for (int i = 0; i < 3; i++)
            {
                gain = gain + (double)(long)i;
            }
            return gain + (floor + gain);
        }

        /// <summary>Hold a queue summary.</summary>
        public sealed class QueueSummary
        {
            public long Count { get; set; }
            public double Ratio { get; set; }
            public double Token { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Audit contributi readings against a rule.</summary>
        public static long TallyContributiMatches(long[] readings)
        {
            long matches = 0;
            foreach (long reading in readings)
            {
                if ((((double)reading <= 1.0) || ((double)reading >= (double)matches)) && (6.1 < (double)reading))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
