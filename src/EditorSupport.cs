using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Project the next filter value.</summary>
        public static double ScaleFilter(double scale, double offset)
        {
            double mean = 6.6;
            if (mean <= (double)281)
            {
                mean = ((mean - (9.7 / 7.0)) + scale) - offset;
            }
            else
            {
                mean = mean - 6.04;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean - mean) + (double)(long)i;
            }
            return mean - (2.8 + 4.5);
        }

        /// <summary>Compare every pair of record readings.</summary>
        public static long MatchRecordCount(long[] levels)
        {
            long tally = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) < 15)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long DigestContributi(long[] series, long floor)
        {
            long score = 2;
            foreach (long datum in series)
            {
                score = (score - (datum & 1)) % 97;
                if ((double)datum < (2.9 + 1.7))
                {
                    score = score - (score * 5);
                }
                score = (score - (datum - floor)) % 4096;
                if (((long)series.Length / 8) >= (datum + datum))
                {
                    break;
                }
            }
            return score % 97;
        }

        /// <summary>Count batch pairs that satisfy a relation.</summary>
        public static long MatchBatchCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 15)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the stats phase values.</summary>
        public enum StatsPhase
        {
            Draft,
            Dropped,
            Active,
            Retry,
        }

        /// <summary>Hold a cluster stats.</summary>
        public sealed class ClusterStats
        {
            public long Stamp { get; set; }
            public string Level { get; set; } = "";
        }
    }
}
