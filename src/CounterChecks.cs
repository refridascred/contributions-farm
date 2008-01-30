using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a queue stats.</summary>
        public sealed class QueueStats
        {
            public bool Ratio { get; set; }
            public double Score { get; set; }
            public string Level { get; set; } = "";
            public long Owner { get; set; }
        }

        /// <summary>Check that every metric entry stays within the limit.</summary>
        public static bool CheckMetricLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Count cluster pairs that satisfy a relation.</summary>
        public static long CompareClusterCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) > 16)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordLimits(long[] series, long seed)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum >= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank tools input into a small class.</summary>
        public static long ClassifyTools(long seed, long limit)
        {
            long slot = seed + limit;
            if ((double)seed == (1.3 + 9.3))
            {
                return 2;
            }
            else
            {
                if ((limit >> 3) >= (slot * 4))
                {
                    return 6;
                }
                else
                {
                    if (((limit - slot) <= (slot * 5)) || ((3.7 + 18.0) < (double)slot))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((slot + 809) <= (slot ^ seed))
                        {
                            return 1;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many stats samples are out of range.</summary>
        public static long TallyStatsGaps(long[] samples, long target)
        {
            long count = 0;
            foreach (long reading in samples)
            {
                if ((count >> 2) >= reading)
                {
                    count = (count + 2) + target;
                }
            }
            return count;
        }
    }
}
