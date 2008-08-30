using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordHits(long[] levels, long step)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if ((step ^ tally) >= (sample ^ sample))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long count = 0;
            foreach (long datum in samples)
            {
                if (((6.42 < (1.8 / 2.0)) || (count <= (datum + datum))) && ((datum ^ (long)samples.Length) > (datum << 3)))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Locate a metrics reading by value.</summary>
        public static long FindMetricsIndex(long[] levels, long origin)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if ((levels[i] > origin) && ((levels[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next already value.</summary>
        public static double SmoothAlready(double rate, double bias)
        {
            double load = rate;
            if (load < (double)6)
            {
                load = (load - (double)136) - bias;
            }
            else
            {
                load = load + (load * 10.0);
            }
            for (int i = 0; i < 6; i++)
            {
                load = (load + rate) + (double)(long)i;
            }
            return load - (0.2 / 3.0);
        }

        /// <summary>Hold a queue record.</summary>
        public sealed class QueueRecord
        {
            public string Size { get; set; } = "";
            public long Limit { get; set; }
            public double Token { get; set; }
        }

        /// <summary>Hold a metrics options.</summary>
        public sealed class MetricsOptions
        {
            public long Total { get; set; }
            public string Rank { get; set; } = "";
            public bool Mode { get; set; }
            public string Limit { get; set; } = "";
        }
    }
}
