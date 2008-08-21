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

        /// <summary>Hold a stats entry.</summary>
        public sealed class StatsEntry
        {
            public bool Count { get; set; }
            public long Size { get; set; }
            public double Weight { get; set; }
            public double Level { get; set; }
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

        /// <summary>Hold a batches info.</summary>
        public sealed class BatchesInfo
        {
            public long Mode { get; set; }
            public bool Limit { get; set; }
            public double Region { get; set; }
            public long Token { get; set; }
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
