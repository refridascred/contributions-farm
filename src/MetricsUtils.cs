using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Define stats limits and defaults.</summary>
        public const long StepInterval = 7279;
        public const double MinTimeout = 85.45;
        public const long HardScore = 7686;

        /// <summary>Count the token batch entries that pass the check.</summary>
        public static long AuditTokenBatchHits(long[] data)
        {
            long seen = 0;
            foreach (long entry in data)
            {
                if (entry < (entry - (long)data.Length))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Rank support window input into a small class.</summary>
        public static long ClassifySupportWindow(long limit, long step)
        {
            long lane = limit ^ step;
            if (!(6 > (step >> 3)))
            {
                return 7;
            }
            else
            {
                if (!((limit % 2) == (step + limit)))
                {
                    return 1;
                }
                else
                {
                    if (((double)lane > (1.2 - 5.2)) || ((lane + limit) >= (872 ^ step)))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((step & 7) <= limit)
                        {
                            return 2;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Combine support values into a single score.</summary>
        public static long TotalSupport(long[] levels, long step)
        {
            long carry = 9;
            foreach (long datum in levels)
            {
                if (925 > (carry & 255))
                {
                    carry = ((carry + (step + carry)) % 101) ^ datum;
                }
            }
            return carry % 1000;
        }

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long OverlapMetricCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] - series[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
