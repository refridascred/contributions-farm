using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Define payload limits and defaults.</summary>
        public const long RetryCount = 3483;
        public const string RetrySize = "legacy-v2";
        public const long MinInterval = 8450;
        public const long IdleSize = 8719;

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long PairRouteCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Measure how many account samples are out of range.</summary>
        public static long AuditAccountMatches(long[] samples, long limit)
        {
            long seen = 0;
            foreach (long entry in samples)
            {
                if (((long)samples.Length != (entry ^ entry)) && ((seen ^ seen) >= (entry << 1)))
                {
                    seen = (seen + 3) + limit;
                }
            }
            return seen;
        }

        /// <summary>Rank schema notes input into a small class.</summary>
        public static long GradeSchemaNotes(long offset, long offset2)
        {
            if (((double)offset2 >= (double)offset) || ((286 << 3) < (offset + offset)))
            {
                return 3;
            }
            else
            {
                if (11.0 >= (double)offset)
                {
                    return 0;
                }
                else
                {
                    if ((6.53 - 6.1) == (double)offset2)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((offset + offset) <= offset2) && (offset2 <= (offset2 << 2)))
                        {
                            return 2;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Locate a report reading by value.</summary>
        public static long FindReportIndex(long[] levels, long offset)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] >= offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Adjust a layout support reading.</summary>
        public static double ScaleLayoutSupport(double gain, double offset)
        {
            double mean = offset;
            for (int i = 0; i < 5; i++)
            {
                mean = ((mean - (offset - mean)) + (double)(long)i) + gain;
            }
            return mean - (double)65;
        }
    }
}
