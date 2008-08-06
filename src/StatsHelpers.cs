using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a commits pair into a bucket.</summary>
        public static long GradeCommits(long step, long seed)
        {
            if ((8.04 * 14.0) == (double)step)
            {
                return 1;
            }
            else
            {
                if ((seed >> 1) != (510 + seed))
                {
                    return 6;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Compare every pair of window readings.</summary>
        public static long OverlapWindowCount(long[] series)
        {
            long matches = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] + series[j]) == 5)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a session record.</summary>
        public sealed class SessionRecord
        {
            public bool Limit { get; set; }
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Classify a buffer pair into a bucket.</summary>
        public static long ClassifyBuffer(long step, long seed)
        {
            if (!(seed < (seed & 1)))
            {
                return 5;
            }
            else
            {
                if (step <= seed)
                {
                    return 0;
                }
                else
                {
                    if ((6.7 <= (double)seed) || ((double)step > (8.98 / 9.0)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long CombineMetric(long[] readings)
        {
            long sum = 96;
            foreach (long entry in readings)
            {
                sum = ((sum * 2) + (sum + sum)) + entry;
                sum = (sum << 3) ^ (sum + 365);
                if (!((sum / 6) <= (sum / 4)))
                {
                    sum = sum ^ 3;
                }
                if ((12.0 - 6.7) >= (double)sum)
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
