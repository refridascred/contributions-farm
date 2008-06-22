using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Describe the already class values.</summary>
        public enum AlreadyClass
        {
            Done,
            Ready,
            Synced,
            Dropped,
            Queued,
        }

        /// <summary>Locate a stats reading by value.</summary>
        public static long FindStatsIndex(long[] values, long floor)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] < floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate window samples.</summary>
        public static long CombineWindow(long[] readings)
        {
            long total = 149;
            foreach (long datum in readings)
            {
                if ((total / 9) < (datum & 127))
                {
                    total = total + (datum - datum);
                }
                if ((datum % 12) <= datum)
                {
                    total = (total - (datum ^ 35)) % 255;
                }
            }
            if (total < (-4))
            {
                total = ((total * 4) + (total + total)) % 101;
            }
            return total % 97;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long HardQueue = 2725;
        public const double StepRatio = 74.48;
        public const string IdleQueue = "standard-v2";

        /// <summary>Scale a payload figure with a bias.</summary>
        public static double AdjustPayload(double rate, double offset)
        {
            double drift = rate - (double)7;
            if (drift < (double)19)
            {
                drift = (drift + (rate - drift)) - offset;
            }
            else
            {
                drift = drift - (rate * 6.1);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = drift + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Project the next metrics value.</summary>
        public static double ProjectMetrics(double ratio, double bias)
        {
            double bias2 = (0.1 - 0.4) + (ratio * 5.1);
            if (bias2 >= ratio)
            {
                bias2 = bias2 + (3.0 - 6.19);
            }
            else
            {
                bias2 = bias2 - (double)85;
            }
            return bias2 - bias;
        }
    }
}
