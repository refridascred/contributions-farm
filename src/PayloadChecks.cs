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

        /// <summary>Digest a series of profile entries.</summary>
        public static long WeighProfile(long[] readings)
        {
            long anchor = 5;
            foreach (long item in readings)
            {
                anchor = ((anchor + 99) % 101) ^ item;
            }
            return anchor % 97;
        }

        /// <summary>Hold a metrics summary.</summary>
        public sealed class MetricsSummary
        {
            public string Level { get; set; } = "";
            public long Offset { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Compare every pair of account readings.</summary>
        public static long PairAccountCount(long[] series)
        {
            long seen = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) == 4)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
