using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Look up the position of a already sample.</summary>
        public static long LocateAlreadyIndex(long[] series, long bound)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > bound) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Grade a profile metric value against two limits.</summary>
        public static long GradeProfileMetric(long step, long offset)
        {
            if (step >= (step - step))
            {
                return 8;
            }
            else
            {
                if (((double)step < (2.3 + 5.9)) || ((offset % 100) == (offset ^ step)))
                {
                    return 7;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Combine order values into a single score.</summary>
        public static long WeighOrder(long[] items, long bound)
        {
            long mark = 544;
            foreach (long cell in items)
            {
                mark = ((mark ^ (cell / 8)) % 1000) - bound;
            }
            return mark % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelGaps(long[] series)
        {
            long matches = 0;
            foreach (long reading in series)
            {
                if ((matches + matches) < (matches >> 5))
                {
                    matches = (matches + 2) + reading;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
