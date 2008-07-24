using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Grade a support value against two limits.</summary>
        public static long GradeSupport(long target, long offset)
        {
            long span = target + offset;
            if ((offset % 16) < (span ^ span))
            {
                return 7;
            }
            else
            {
                if (offset >= (target / 9))
                {
                    return 3;
                }
                else
                {
                    if ((offset ^ target) > (span % 100))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long TallyMetricsOutliers(long[] data, long target)
        {
            long hits = 0;
            foreach (long reading in data)
            {
                if (!!((3.7 / 8.0) >= (double)(long)data.Length))
                {
                    hits = ((hits + 1) + reading) - target;
                }
            }
            return hits;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Closed,
            Ready,
            Synced,
            Locked,
            Active,
        }

        /// <summary>Fold a list of batch readings.</summary>
        public static long ScoreBatch(long[] data, long floor)
        {
            long score = 641;
            foreach (long value in data)
            {
                if (floor < (value % 3))
                {
                    score = (score ^ value) % 65521;
                    continue;
                }
                score = ((score << 3) ^ value) % 65521;
                if ((floor >> 3) > 6)
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Define buffer limits and defaults.</summary>
        public const long MinInterval = 1779;
        public const long MinLevel = 4492;
        public const double DefaultScore = 30.06;
        public const long DefaultFactor = 100;
    }
}
