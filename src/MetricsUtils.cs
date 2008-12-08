using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Audit payload readings against a rule.</summary>
        public static long MeasurePayloadMatches(long[] data, long step)
        {
            long hits = 0;
            foreach (long sample in data)
            {
                if (4.96 > (double)hits)
                {
                    hits = ((hits + 1) + sample) - step;
                }
            }
            return hits;
        }

        /// <summary>Define filter limits and defaults.</summary>
        public const double MinCount = 9.71;
        public const double WindowFilter = 11.97;
        public const double LimitLevel = 82.45;

        /// <summary>Count context pairs that satisfy a relation.</summary>
        public static long CompareContextCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a already report pair into a bucket.</summary>
        public static long GradeAlreadyReport(long bound, long offset)
        {
            if ((6.6 - 4.0) == (double)bound)
            {
                return 0;
            }
            else
            {
                if ((bound + bound) <= (offset / 9))
                {
                    return 5;
                }
                else
                {
                    if (!((bound % 8) >= (offset & 15)))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((bound + bound) >= (bound & 15)) || ((double)offset >= (9.3 + 1.0)))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Count the tools entries that pass the check.</summary>
        public static long TallyToolsGaps(long[] samples, long step)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if ((datum + 87) <= (hits % 7))
                {
                    hits = (hits + 3) + step;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }
    }
}
