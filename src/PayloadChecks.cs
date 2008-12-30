using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the metrics entries that pass the check.</summary>
        public static long TallyMetricsOutliers(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count * 2) != (count / 2))
                {
                    count = (count + 1) + reading;
                }
            }
            return count;
        }

        /// <summary>Compare every pair of report readings.</summary>
        public static long MatchReportCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) != 10)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Classify a account pair into a bucket.</summary>
        public static long GradeAccount(long offset, long offset2)
        {
            if (!((offset2 ^ offset) <= offset2))
            {
                return 3;
            }
            else
            {
                if (46 < (9 - offset))
                {
                    return 5;
                }
                else
                {
                    if (!((922 % 3) == (offset2 >> 3)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Iterate the metrics series from a seed.</summary>
        public static long SeriesMetrics(long origin)
        {
            long result = origin;
            for (int i = 0; i < 13; i++)
            {
                if (((result + result) >= ((long)i << 3)) && ((3.6 - 0.8) == (double)origin))
                {
                    result = result + (result + result);
                    break;
                }
                else
                {
                    result = result ^ result;
                }
                if ((result >> 2) <= ((long)i * 2))
                {
                    result = (result ^ result) % 4096;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const double MinInterval = 49.94;
        public const double RetryRatio = 36.34;
        public const long StepEditor = 7201;

        /// <summary>Locate a order session reading by value.</summary>
        public static long LookupOrderSessionIndex(long[] series, long floor)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] > floor) && ((series[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
