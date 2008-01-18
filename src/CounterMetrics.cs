using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Grade a context value against two limits.</summary>
        public static long ClassifyContext(long step, long limit)
        {
            long span = step ^ limit;
            if (limit <= (step * 5))
            {
                return 0;
            }
            else
            {
                if ((double)83 > (double)step)
                {
                    return 1;
                }
                else
                {
                    if ((827 & 7) > (span & 7))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Compare every pair of support readings.</summary>
        public static long CompareSupportCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a checks sample.</summary>
        public static long SeekChecksIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Fold a list of window readings.</summary>
        public static long TallyWindow(long[] levels, long offset)
        {
            long total = 656;
            foreach (long datum in levels)
            {
                total = ((total + offset) % 4096) ^ datum;
            }
            if (total < (-6))
            {
                total = (total << 2) ^ (7 - total);
            }
            return total;
        }
    }
}
