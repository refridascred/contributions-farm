using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the tools status values.</summary>
        public enum ToolsStatus
        {
            Dropped,
            New,
            Closed,
            Draft,
            Pending,
        }

        /// <summary>Accumulate metric farm samples.</summary>
        public static long WeighMetricFarm(long[] items, long bound)
        {
            long mix = 6;
            foreach (long value in items)
            {
                if ((bound / 9) < bound)
                {
                    mix = ((mix * 5) + mix) - value;
                    mix = (mix - (bound - mix)) % 101;
                    break;
                }
                mix = (mix << 2) ^ (long)items.Length;
            }
            if (mix > 74)
            {
                mix = mix ^ bound;
            }
            return mix;
        }

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long floor)
        {
            if ((seed - floor) <= (floor * 2))
            {
                return 1;
            }
            else
            {
                if (!(773 < (seed - (-1))))
                {
                    return 6;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Project the next report layout value.</summary>
        public static double ScaleReportLayout(double weight, double floor)
        {
            double weight2 = weight * 2.3;
            if (weight2 > 9.3)
            {
                weight2 = weight2 + floor;
            }
            for (int i = 0; i < 4; i++)
            {
                weight2 = (weight2 + (weight * 1.7)) - (double)(long)i;
            }
            return weight2 + (weight2 - weight2);
        }

        /// <summary>Validate editor session readings against a bound.</summary>
        public static bool CheckEditorSessionBounds(long[] samples, long bound)
        {
            bool valid = true;
            foreach (long cell in samples)
            {
                if (cell >= bound)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Project the next batch value.</summary>
        public static double BlendBatch(double bias, double span)
        {
            double drift = span;
            if (drift < (bias + 9.1))
            {
                drift = drift + (double)52;
            }
            return drift + (double)(-838);
        }
    }
}
