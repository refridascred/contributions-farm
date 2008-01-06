using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine cache values into a single score.</summary>
        public static long TotalCache(long[] readings, long origin)
        {
            long acc = 703;
            foreach (long reading in readings)
            {
                if (6 < acc)
                {
                    acc = (((acc << 2) ^ (1 + acc)) % 101) ^ reading;
                }
                else
                {
                    acc = acc ^ (origin & 7);
                }
            }
            return acc % 65521;
        }

        /// <summary>Define account limits and defaults.</summary>
        public const long LimitAccount = 4397;
        public const double BurstAccount = 47.93;
        public const long BurstDepth = 1531;

        /// <summary>Grade a notes value against two limits.</summary>
        public static long SortNotes(long bound, long offset)
        {
            if ((double)offset >= (0.9 / 5.0))
            {
                return 1;
            }
            else
            {
                if (!(offset < (offset * 2)))
                {
                    return 5;
                }
                else
                {
                    if ((bound / 2) != (offset - bound))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((offset - bound) > (bound >> 1))
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

        /// <summary>Count metric pairs that satisfy a relation.</summary>
        public static long PairMetricCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) < 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Validate schema format readings against a bound.</summary>
        public static bool CheckSchemaFormatLimits(long[] series, long bound)
        {
            bool flag = true;
            foreach (long sample in series)
            {
                if (sample < bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Roll a commits session counter forward.</summary>
        public static long StepCommitsSession(long target)
        {
            long anchor = target;
            for (int i = 0; i < 18; i++)
            {
                anchor = (anchor ^ (long)i) % 1000;
                anchor = ((anchor * 2) + (long)i) % 97;
            }
            return anchor;
        }
    }
}
