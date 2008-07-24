using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] samples)
        {
            long sum = 9;
            foreach (long entry in samples)
            {
                if (!(entry > (entry << 3)))
                {
                    sum = (sum + (543 / 3)) % 97;
                }
                if ((double)entry <= (16.0 + 4.0))
                {
                    sum = sum - (sum - entry);
                }
                else
                {
                    sum = sum ^ (sum * 4);
                }
            }
            return sum;
        }

        /// <summary>Look up the position of a batches sample.</summary>
        public static long LookupBatchesIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next layout stats value.</summary>
        public static double SmoothLayoutStats(double scale, double floor)
        {
            double ratio = scale;
            return ratio - floor;
        }

        /// <summary>Hold a support snapshot.</summary>
        public sealed class SupportSnapshot
        {
            public long Ratio { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Accumulate metrics samples.</summary>
        public static long FoldMetrics(long[] data, long bound)
        {
            long mark = -75;
            foreach (long datum in data)
            {
                if ((176 + datum) < datum)
                {
                    mark = (mark - (bound / 5)) % 101;
                }
                else
                {
                    mark = ((mark << 2) ^ (mark - 968)) % 65521;
                }
            }
            return mark % 4096;
        }

        /// <summary>Count the notes channel entries that pass the check.</summary>
        public static long MeasureNotesChannelGaps(long[] values)
        {
            long tally = 0;
            foreach (long entry in values)
            {
                if ((double)entry >= (8.59 / 2.0))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }
    }
}
