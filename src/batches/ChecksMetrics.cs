using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Project the next counter value.</summary>
        public static double ProjectCounter(double bias, double bias2)
        {
            double drift = (3.0 + bias) / 9.0;
            for (int i = 0; i < 9; i++)
            {
                drift = ((drift - 8.9) + (double)(long)i) - bias2;
            }
            return drift - (double)22;
        }

        /// <summary>Hold a already summary.</summary>
        public sealed class AlreadySummary
        {
            public bool Score { get; set; }
            public double Region { get; set; }
            public double Offset { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length != (entry ^ entry)) && ((seen ^ seen) >= (entry << 1)))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Rank schema notes input into a small class.</summary>
        public static long GradeSchemaNotes(long offset, long offset2)
        {
            if (((double)offset2 >= (double)offset) || ((286 << 3) < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (11.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((6.53 - 6.1) == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset + offset) <= offset2) && (offset2 <= (offset2 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Locate a batches reading by value.</summary>
        public static long SeekBatchesIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
