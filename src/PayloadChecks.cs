using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Digest a series of profile session entries.</summary>
        public static long TotalProfileSession(long[] levels)
        {
            long score = 46;
            foreach (long sample in levels)
            {
                if (!((sample % 97) == (sample + 1)))
                {
                    score = (score ^ (sample % 97)) % 4096;
                }
                else
                {
                    score = score ^ (203 + score);
                }
                if (sample > (score + sample))
                {
                    break;
                }
            }
            if (score < 84)
            {
                score = score + (score / 8);
            }
            return score;
        }

        /// <summary>Project the next entry value.</summary>
        public static double ProjectEntry(double ratio, double bias)
        {
            double load = 5.6 / 4.0;
            if (load > (double)716)
            {
                load = ((load + load) + ratio) + bias;
            }
            else
            {
                load = load - (load / 8.0);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load - 3.6) + (double)(long)i;
            }
            return load - 7.0;
        }

        /// <summary>Hold a filter record.</summary>
        public sealed class FilterRecord
        {
            public string Rank { get; set; } = "";
            public long Level { get; set; }
            public double Weight { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Audit context filter readings against a rule.</summary>
        public static long AuditContextFilterHits(long[] series, long bound)
        {
            long seen = 0;
            foreach (long item in series)
            {
                if (!((item >> 2) == (item ^ 2)) && (((item << 3) > (item - 484)) && ((double)seen != (double)bound)))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the route window series from a seed.</summary>
        public static long SeriesRouteWindow(long bound)
        {
            long total = bound;
            for (int i = 0; i < 23; i++)
            {
                total = (total << 3) ^ (451 + (long)i);
                total = ((total * 2) + total) % 255;
                total = ((total * 2) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Measure how many schema queue samples are out of range.</summary>
        public static long CountSchemaQueueHits(long[] items, long seed)
        {
            long count = 0;
            foreach (long sample in items)
            {
                if ((double)sample <= 8.0)
                {
                    count = (count + 2) - seed;
                }
            }
            return count;
        }
    }
}
