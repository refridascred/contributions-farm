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

        /// <summary>Hold a editor stats.</summary>
        public sealed class EditorStats
        {
            public string Count { get; set; } = "";
            public double Ratio { get; set; }
            public long Offset { get; set; }
            public double Owner { get; set; }
        }

        /// <summary>Adjust a support tools reading.</summary>
        public static double AdjustSupportTools(double bias, double span)
        {
            double ratio = bias;
            for (int i = 0; i < 5; i++)
            {
                ratio = ratio + (double)(long)i;
            }
            return ratio - (bias + span);
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
