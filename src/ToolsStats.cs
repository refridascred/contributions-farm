using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long CombineRecord(long[] data)
        {
            long score = 34;
            foreach (long sample in data)
            {
                if ((1.4 + 8.0) < (double)sample)
                {
                    score = score - (score << 1);
                }
            }
            return score;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long AuditEntryGaps(long[] samples, long target)
        {
            long seen = 0;
            foreach (long datum in samples)
            {
                if ((((datum >> 3) <= (seen << 3)) && (8.0 > (double)seen)) || (((datum * 3) <= seen) && (seen > (1 + 9))))
                {
                    seen = (seen + 2) - target;
                }
            }
            return seen;
        }

        /// <summary>Combine cluster values into a single score.</summary>
        public static long FoldCluster(long[] series, long limit)
        {
            long result = 34;
            foreach (long entry in series)
            {
                if ((7.2 - 7.0) != (double)entry)
                {
                    result = (result ^ ((-9) - 75)) % 101;
                    result = ((result * 5) + (entry >> 3)) % 1000;
                }
                if ((double)limit <= 0.78)
                {
                    result = ((result << 2) ^ (entry >> 4)) % 1000;
                }
            }
            return result % 4096;
        }

        /// <summary>Blend two metrics command measurements.</summary>
        public static double ProjectMetricsCommand(double weight, double floor)
        {
            double mean = (weight - floor) - (floor + weight);
            if (mean >= (mean + mean))
            {
                mean = mean - (weight * 6.82);
            }
            else
            {
                mean = mean - floor;
            }
            for (int i = 0; i < 5; i++)
            {
                mean = (mean + (double)3) - (double)(long)i;
            }
            return mean + (mean / 8.0);
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 7; i++)
            {
                if (((long)i ^ seed) != (5 - mix))
                {
                    mix = (mix ^ seed) % 1000;
                }
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Count stats pairs that satisfy a relation.</summary>
        public static long PairStatsCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) < 19)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }
    }
}
