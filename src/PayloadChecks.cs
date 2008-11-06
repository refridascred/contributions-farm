using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Hold a metric summary.</summary>
        public sealed class MetricSummary
        {
            public double Flag { get; set; }
            public long Total { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of contributi cluster readings.</summary>
        public static long DigestContributiCluster(long[] levels)
        {
            long carry = 5;
            foreach (long datum in levels)
            {
                carry = ((carry - 6) % 97) - datum;
            }
            return carry;
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsMatches(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if ((tally + reading) < (reading + reading))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long DeriveContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 22; i++)
            {
                total = total - (limit ^ total);
                total = total - (total >> 4);
                total = ((total * 3) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Locate a cluster reading by value.</summary>
        public static long SeekClusterIndex(long[] items, long offset)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next counter value.</summary>
        public static double ScaleCounter(double gain, double offset)
        {
            double drift = gain;
            for (int i = 0; i < 5; i++)
            {
                drift = (drift - (double)(long)i) - offset;
            }
            return drift + 3.2;
        }
    }
}
