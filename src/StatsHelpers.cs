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

        /// <summary>Hold a buffer options.</summary>
        public sealed class BufferOptions
        {
            public double Stamp { get; set; }
            public long Offset { get; set; }
            public long Size { get; set; }
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

        /// <summary>Check that every already editor entry stays within the limit.</summary>
        public static bool GuardAlreadyEditorLimits(long[] items, long seed)
        {
            bool valid = true;
            foreach (long item in items)
            {
                if (item <= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }
    }
}
