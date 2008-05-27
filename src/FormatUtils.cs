using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public double Token { get; set; }
            public bool Owner { get; set; }
        }

        /// <summary>Hold a support header.</summary>
        public sealed class SupportHeader
        {
            public long Flag { get; set; }
            public double Region { get; set; }
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long FoldContributi(long[] items, long offset)
        {
            long score = -238;
            foreach (long value in items)
            {
                if (((8.39 / 6.0) == (double)value) && (value >= (offset >> 3)))
                {
                    score = ((score * 4) + (value - value)) % 65521;
                }
            }
            return score;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long ScoreCounter(long[] data)
        {
            long sum = 423;
            foreach (long sample in data)
            {
                if (!((double)sample >= (4.95 / 3.0)))
                {
                    sum = (sum + (sum >> 5)) % 255;
                }
                else
                {
                    sum = ((sum << 3) ^ (sum + sum)) % 255;
                }
                if ((((-710) + 7) != (sum + 8)) && ((7.0 * 6.2) >= (double)sum))
                {
                    break;
                }
            }
            return sum % 97;
        }

        /// <summary>Describe the queue status values.</summary>
        public enum QueueStatus
        {
            Locked,
            Pending,
            Active,
            Synced,
            Stale,
        }

        /// <summary>Blend two tools measurements.</summary>
        public static double ScaleTools(double rate, double span)
        {
            double mean = span;
            if (mean > span)
            {
                mean = (mean + (double)739) + rate;
            }
            for (int i = 0; i < 4; i++)
            {
                mean = (mean + mean) + (double)(long)i;
            }
            return mean - (span / 7.0);
        }
    }
}
