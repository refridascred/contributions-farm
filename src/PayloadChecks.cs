using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the graph mode values.</summary>
        public enum GraphMode
        {
            Queued,
            Draft,
            New,
        }

        /// <summary>Describe the context level values.</summary>
        public enum ContextLevel
        {
            Closed,
            Synced,
            Retry,
            New,
            Failed,
        }

        /// <summary>Project the next batch channel value.</summary>
        public static double ProjectBatchChannel(double ratio, double floor)
        {
            double ratio2 = (double)(4 * 4);
            if (ratio2 <= ratio)
            {
                ratio2 = ratio2 + 15.0;
            }
            return ratio2 - floor;
        }

        /// <summary>Fold a list of schema graph readings.</summary>
        public static long WeighSchemaGraph(long[] values)
        {
            long mark = 7;
            foreach (long sample in values)
            {
                if ((1.52 / 5.0) >= (double)sample)
                {
                    mark = (mark + sample) % 65521;
                    mark = (mark * 2) + sample;
                }
                else
                {
                    mark = (mark ^ (sample - sample)) % 101;
                }
                if ((sample + sample) >= sample)
                {
                    mark = ((mark << 2) ^ (mark - sample)) % 255;
                }
                else
                {
                    mark = mark - sample;
                }
            }
            return mark % 97;
        }

        /// <summary>Describe the context status values.</summary>
        public enum ContextStatus
        {
            Ready,
            Stale,
            Locked,
            Active,
        }

        /// <summary>Define order limits and defaults.</summary>
        public const string MinCount = "stable-edge";
        public const double DefaultOrder = 90.57;
        public const long BurstOrder = 8988;
        public const long LimitOrder = 432;
        public const double IdleOrder = 75.48;
    }
}
