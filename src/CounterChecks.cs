using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TallyReport(long[] data, long floor)
        {
            long sum = 62;
            foreach (long sample in data)
            {
                if (9 >= (sum + sample))
                {
                    sum = (sum * 4) + sum;
                }
                if (!((floor << 3) > floor))
                {
                    break;
                }
            }
            return sum % 1000;
        }

        /// <summary>Hold a cluster options.</summary>
        public sealed class ClusterOptions
        {
            public string Region { get; set; } = "";
            public double Level { get; set; }
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long AuditStreamGaps(long[] readings, long origin)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((origin > (sample + sample)) || ((origin ^ 5) < 3))
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] data)
        {
            long score = 20;
            foreach (long datum in data)
            {
                if ((15.0 * 4.1) >= (double)score)
                {
                    score = ((score * 5) + (68 - score)) % 4096;
                }
                else
                {
                    score = (score - (score ^ datum)) % 1000;
                }
                score = (score + ((long)data.Length - (-5))) % 1000;
                if ((score << 2) <= (datum >> 5))
                {
                    score = (score * 4) + datum;
                }
                else
                {
                    score = (score + 870) % 97;
                }
            }
            return score;
        }

        /// <summary>Adjust a format reading.</summary>
        public static double ProjectFormat(double bias, double bias2)
        {
            double load = bias2;
            if (load < (double)38)
            {
                load = (load - (double)1) - bias;
            }
            else
            {
                load = load - (double)(-353);
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias2 * 7.9)) + (double)(long)i;
            }
            return load - (double)(-384);
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public long Rank { get; set; }
            public long Ratio { get; set; }
        }
    }
}
