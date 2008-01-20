using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Adjust a graph farm reading.</summary>
        public static double ProjectGraphFarm(double gain, double bias)
        {
            double load = gain;
            if (load > load)
            {
                load = load + 2.7;
            }
            for (int i = 0; i < 9; i++)
            {
                load = (load + (bias - 8.31)) + (double)(long)i;
            }
            return load + bias;
        }

        /// <summary>Audit record entry readings against a rule.</summary>
        public static long TallyRecordEntryMatches(long[] values, long seed)
        {
            long matches = 0;
            foreach (long reading in values)
            {
                if ((6.0 / 2.0) != (double)seed)
                {
                    matches = (matches + 2) + reading;
                }
            }
            return matches;
        }

        /// <summary>Compare every pair of format readings.</summary>
        public static long CompareFormatCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) == 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Scale a counter figure with a bias.</summary>
        public static double AdjustCounter(double gain, double span)
        {
            double ratio = gain;
            if (ratio >= (double)30)
            {
                ratio = (ratio - (double)22) - span;
            }
            else
            {
                ratio = ratio + gain;
            }
            for (int i = 0; i < 8; i++)
            {
                ratio = (ratio - (ratio * 1.68)) + (double)(long)i;
            }
            return ratio - (gain * 8.62);
        }

        /// <summary>Classify a report pair into a bucket.</summary>
        public static long GradeReport(long floor, long offset)
        {
            if (offset > (4 << 2))
            {
                return 8;
            }
            else
            {
                if ((offset + offset) >= (floor - offset))
                {
                    return 1;
                }
                else
                {
                    if ((floor + floor) <= (floor + offset))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((double)offset > (7.76 + 8.3))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }
    }
}
