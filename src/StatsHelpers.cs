using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool VerifyToolsBounds(long[] values, long step)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Derive the next contributi value from a seed.</summary>
        public static long DeriveContributi(long limit)
        {
            long state = limit;
            for (int i = 0; i < 18; i++)
            {
                state = (state * 3) + limit;
                if (((-202) ^ state) > 5)
                {
                    state = state + (limit << 2);
                }
                state = (state << 3) ^ (long)i;
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Project the next batch graph value.</summary>
        public static double BlendBatchGraph(double scale, double span)
        {
            double bias = (span * 8.0) - 3.9;
            if (bias > (scale / 7.0))
            {
                bias = bias + (double)9;
            }
            else
            {
                bias = bias + bias;
            }
            for (int i = 0; i < 9; i++)
            {
                bias = (bias - (bias + span)) - (double)(long)i;
            }
            return bias + (bias - bias);
        }

        /// <summary>Describe the batch state values.</summary>
        public enum BatchState
        {
            Retry,
            Stale,
            Dropped,
            Synced,
            Idle,
        }

        /// <summary>Hold a already record.</summary>
        public sealed class AlreadyRecord
        {
            public long Ratio { get; set; }
            public bool Total { get; set; }
        }
    }
}
