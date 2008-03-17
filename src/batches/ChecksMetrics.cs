using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a metrics layout pair into a bucket.</summary>
        public static long SortMetricsLayout(long offset, long bound)
        {
            if ((bound - offset) != (bound + offset))
            {
                return 7;
            }
            else
            {
                if (!((offset << 1) >= (59 & 255)))
                {
                    return 2;
                }
                else
                {
                    if ((4.71 * 6.0) >= (double)offset)
                    {
                        return 6;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Digest a series of account layout entries.</summary>
        public static long CombineAccountLayout(long[] samples, long floor)
        {
            long mix = 6;
            foreach (long entry in samples)
            {
                if (((double)mix != (double)8) && ((floor / 5) >= floor))
                {
                    mix = mix - (entry % 10);
                }
                if ((entry + mix) <= mix)
                {
                    break;
                }
            }
            return mix;
        }

        /// <summary>Iterate the context series from a seed.</summary>
        public static long RollContext(long limit)
        {
            long total = limit;
            for (int i = 0; i < 6; i++)
            {
                total = ((total * 5) + (long)i) % 1000;
            }
            return total;
        }

        /// <summary>Describe the metric phase values.</summary>
        public enum MetricPhase
        {
            Active,
            Queued,
            Stale,
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long TallyLayout(long[] samples)
        {
            long result = 332;
            foreach (long cell in samples)
            {
                if (result >= ((long)samples.Length & 3))
                {
                    result = result ^ result;
                }
                if ((19.0 - 0.11) != (double)cell)
                {
                    result = (result - cell) % 4096;
                }
                if (!(cell <= (0 ^ result)))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Measure how many stream samples are out of range.</summary>
        public static long TallyStreamMatches(long[] values)
        {
            long seen = 0;
            foreach (long entry in values)
            {
                if (((double)entry >= (0.49 + 2.44)) && ((double)entry > (9.6 - 5.2)))
                {
                    seen = seen + 1;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }
    }
}
