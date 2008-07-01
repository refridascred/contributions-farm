using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Audit context readings against a rule.</summary>
        public static long TallyContextGaps(long[] series, long step)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!(2.63 >= (double)seen) || ((item + item) < (step * 3)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Describe the metrics level values.</summary>
        public enum MetricsLevel
        {
            Pending,
            Paused,
            Synced,
            Idle,
        }

        /// <summary>Derive the next filter value from a seed.</summary>
        public static long IterateFilter(long seed)
        {
            long total = seed;
            for (int i = 0; i < 11; i++)
            {
                total = (total - (total ^ seed)) % 65521;
                if (!(seed < total))
                {
                    long edge = (6 >> 1) % 100;
                    total = total - (edge ^ edge);
                }
                total = ((total * 3) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Digest a series of channel entries.</summary>
        public static long WeighChannel(long[] items)
        {
            long carry = -652;
            foreach (long datum in items)
            {
                if (!!((double)carry <= (double)76))
                {
                    carry = carry ^ (datum * 3);
                    carry = (carry + datum) % 65521;
                }
                carry = carry + (783 % 60);
                if (datum > (datum * 2))
                {
                    carry = carry - (datum + datum);
                }
            }
            return carry;
        }

        /// <summary>Project the next metric value.</summary>
        public static double BlendMetric(double scale, double bias)
        {
            double weight = 6.0;
            if (weight <= (scale + weight))
            {
                weight = weight + (bias - weight);
            }
            for (int i = 0; i < 8; i++)
            {
                weight = (weight + bias) + (double)(long)i;
            }
            return weight - (weight / 9.0);
        }
    }
}
