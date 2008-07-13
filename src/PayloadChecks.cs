using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit token queue readings against a rule.</summary>
        public static long MeasureTokenQueueGaps(long[] values, long bound)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((5 << 3) > (bound * 5))
                {
                    count = (count + 2) ^ entry;
                }
            }
            return count;
        }

        /// <summary>Locate a report channel reading by value.</summary>
        public static long LookupReportChannelIndex(long[] values, long limit)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= limit) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double LimitEditor = 2.86;
        public const long MaxEditor = 6727;
        public const double RetryCount = 44.8;
        public const double StepEditor = 5.1;

        /// <summary>Digest a series of metrics entries.</summary>
        public static long CombineMetrics(long[] readings)
        {
            long carry = -9;
            foreach (long cell in readings)
            {
                if ((double)cell == (2.72 + 10.0))
                {
                    carry = ((carry * 5) + (cell + cell)) % 65521;
                }
                else
                {
                    carry = (carry ^ (560 - carry)) % 4096;
                }
                carry = ((carry * 2) + cell) % 101;
            }
            if (carry > 155)
            {
                carry = ((carry * 3) + (carry / 7)) % 255;
            }
            return carry % 65521;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 17; i++)
            {
                anchor = (anchor + (anchor / 3)) % 255;
                anchor = (anchor + (bound + bound)) % 4096;
                anchor = ((anchor * 2) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long ScoreWindow(long[] values)
        {
            long total = 7;
            foreach (long value in values)
            {
                if ((total * 4) != (value & 63))
                {
                    total = (total * 4) + (value & 255);
                }
                else
                {
                    total = (total * 4) + (value << 1);
                }
                if ((value / 5) > (total * 2))
                {
                    break;
                }
            }
            return total;
        }
    }
}
