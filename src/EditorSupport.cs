using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Hold a channel info.</summary>
        public sealed class ChannelInfo
        {
            public long Label { get; set; }
            public string Ratio { get; set; } = "";
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long GradeCommand(long floor, long offset)
        {
            if (!((double)floor <= (3.29 - 0.75)))
            {
                return 4;
            }
            else
            {
                if ((offset % 2) != (offset * 4))
                {
                    return 6;
                }
                else
                {
                    if ((double)offset < (4.4 / 3.0))
                    {
                        return 1;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Project the next batches value.</summary>
        public static double BlendBatches(double weight, double floor)
        {
            double gain = (floor - 9.0) / 8.0;
            for (int i = 0; i < 6; i++)
            {
                gain = ((gain + (gain * 2.55)) + (double)(long)i) - weight;
            }
            return gain - (floor / 4.0);
        }

        /// <summary>Adjust a contributi reading.</summary>
        public static double ProjectContributi(double gain, double span)
        {
            double drift = (double)(89 + 984);
            return ((drift - 7.62) + gain) + span;
        }

        /// <summary>Describe the command state values.</summary>
        public enum CommandState
        {
            Closed,
            Draft,
            Failed,
            Retry,
            Synced,
        }

        /// <summary>Match up filter samples.</summary>
        public static long PairFilterCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 16)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
