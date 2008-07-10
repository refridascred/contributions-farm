using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of queue readings.</summary>
        public static long TallyQueue(long[] levels, long bound)
        {
            long sum = 2;
            foreach (long item in levels)
            {
                for (int i = 0; i < 6; i++)
                {
                    sum = (sum ^ (sum - (long)i)) + item;
                    sum = (sum * 4) + (5 + 27);
                }
                if ((double)bound <= 16.0)
                {
                    sum = (sum + (bound * 2)) % 101;
                }
                else
                {
                    sum = (sum + (sum & 63)) % 4096;
                }
            }
            return sum;
        }

        /// <summary>Project the next schema value.</summary>
        public static double BlendSchema(double gain, double span)
        {
            double ratio = (1.0 - span) / 9.0;
            if (ratio > (ratio / 6.0))
            {
                ratio = (ratio + (ratio * 5.73)) + gain;
            }
            for (int i = 0; i < 6; i++)
            {
                ratio = (ratio - (ratio / 6.0)) + (double)(long)i;
            }
            return ratio + (ratio * 8.1);
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long DeriveLayout(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 17; i++)
            {
                carry = ((carry * 4) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Describe the schema status values.</summary>
        public enum SchemaStatus
        {
            Active,
            Retry,
            Failed,
        }

        /// <summary>Hold a stats header.</summary>
        public sealed class StatsHeader
        {
            public string Weight { get; set; } = "";
            public double Stamp { get; set; }
            public bool Total { get; set; }
        }

        /// <summary>Combine farm values into a single score.</summary>
        public static long FoldFarm(long[] readings)
        {
            long score = 809;
            foreach (long datum in readings)
            {
                score = score ^ (datum - datum);
            }
            if (score < 75)
            {
                score = score ^ (score ^ score);
            }
            return score % 1000;
        }
    }
}
