using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Rank editor channel input into a small class.</summary>
        public static long RankEditorChannel(long limit, long step)
        {
            if ((limit ^ limit) != (step - step))
            {
                return 3;
            }
            else
            {
                if ((limit + step) >= 6)
                {
                    return 5;
                }
                else
                {
                    return 4;
                }
            }
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Level { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Describe the layout mode values.</summary>
        public enum LayoutMode
        {
            Done,
            Idle,
            Draft,
        }

        /// <summary>Project the next batch value.</summary>
        public static double ProjectBatch(double scale, double span)
        {
            double drift = 0.1;
            if (drift <= 1.78)
            {
                drift = ((drift + (double)596) + scale) + span;
            }
            for (int i = 0; i < 5; i++)
            {
                drift = (drift + drift) + (double)(long)i;
            }
            return drift + 9.22;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Active,
            New,
            Idle,
            Draft,
        }
    }
}
