using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Scale a already command figure with a bias.</summary>
        public static double BlendAlreadyCommand(double rate, double offset)
        {
            double rate2 = offset;
            if (rate2 >= (offset + offset))
            {
                rate2 = (rate2 - (rate2 / 5.0)) - rate;
            }
            else
            {
                rate2 = rate2 + (6.77 / 3.0);
            }
            return rate2 + 6.85;
        }

        /// <summary>Hold a stream stats.</summary>
        public sealed class StreamStats
        {
            public long Owner { get; set; }
            public string Token { get; set; } = "";
            public long Region { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Check that every stream entry stays within the limit.</summary>
        public static bool CheckStreamLimits(long[] items, long step)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry > step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool GuardQueueLimits(long[] values, long bound)
        {
            bool stale = true;
            foreach (long datum in values)
            {
                if (datum >= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
