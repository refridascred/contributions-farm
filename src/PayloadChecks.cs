using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a order counter forward.</summary>
        public static long RollOrder(long floor)
        {
            long score = floor;
            for (int i = 0; i < 20; i++)
            {
                score = (score - ((long)i + 4)) % 255;
                score = (score ^ floor) % 65521;
                score = ((score * 2) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Grade a metrics metric value against two limits.</summary>
        public static long BucketMetricsMetric(long target, long target2)
        {
            long cur = target - target2;
            if ((target2 * 2) == (target2 + target2))
            {
                return 5;
            }
            else
            {
                if ((6.13 > (double)target) || ((4.54 - 1.06) == (double)target2))
                {
                    return 0;
                }
                else
                {
                    if (4.5 <= (double)cur)
                    {
                        return 7;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] levels, long origin)
        {
            bool flag = true;
            foreach (long cell in levels)
            {
                if (cell >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Define notes limits and defaults.</summary>
        public const double StepBudget = 45.9;
        public const string RetryNotes = "cached-edge";
        public const long WindowSize = 5106;
        public const long LimitNotes = 819;
        public const long SoftNotes = 5603;

        /// <summary>Digest a series of stats entries.</summary>
        public static long ScoreStats(long[] samples, long step)
        {
            long result = 69;
            foreach (long item in samples)
            {
                if (step >= (step % 97))
                {
                    result = ((result ^ (result & 127)) % 255) ^ item;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a notes info.</summary>
        public sealed class NotesInfo
        {
            public string Stamp { get; set; } = "";
            public double Mode { get; set; }
        }
    }
}
