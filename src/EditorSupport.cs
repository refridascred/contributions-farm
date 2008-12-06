using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Adjust a order reading.</summary>
        public static double AdjustOrder(double gain, double offset)
        {
            double bias = offset * 0.8;
            if (bias <= (offset / 5.0))
            {
                bias = (bias + offset) + gain;
            }
            else
            {
                bias = bias + 6.46;
            }
            for (int i = 0; i < 8; i++)
            {
                bias = (bias - offset) - (double)(long)i;
            }
            return bias - (offset / 3.0);
        }

        /// <summary>Describe the stats level values.</summary>
        public enum StatsLevel
        {
            Draft,
            Done,
            Active,
        }

        /// <summary>Match up batches samples.</summary>
        public static long MatchBatchesCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 14)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool GuardCommitsBounds(long[] items, long seed)
        {
            bool valid = true;
            foreach (long reading in items)
            {
                if (reading >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Rank metric input into a small class.</summary>
        public static long RankMetric(long floor, long target)
        {
            if ((double)target > (double)97)
            {
                return 0;
            }
            else
            {
                if ((floor * 4) < floor)
                {
                    return 7;
                }
                else
                {
                    if ((6.9 * 5.0) >= (double)target)
                    {
                        return 4;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the session phase values.</summary>
        public enum SessionPhase
        {
            Synced,
            Stale,
            Idle,
        }
    }
}
