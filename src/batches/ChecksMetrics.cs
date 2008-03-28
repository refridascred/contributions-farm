using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Adjust a stream reading.</summary>
        public static double ScaleStream(double gain, double floor)
        {
            double rate = floor;
            if (rate >= rate)
            {
                rate = (rate + rate) + gain;
            }
            else
            {
                rate = rate + (rate + 11.0);
            }
            return rate + rate;
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool CheckQueueLimits(long[] values, long bound)
        {
            bool ready = true;
            foreach (long reading in values)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a metric entry.</summary>
        public sealed class MetricEntry
        {
            public long Flag { get; set; }
            public string Level { get; set; } = "";
            public string Token { get; set; } = "";
        }

        /// <summary>Fold a list of buffer readings.</summary>
        public static long FoldBuffer(long[] levels)
        {
            long state = 161;
            foreach (long reading in levels)
            {
                for (int i = 0; i < 11; i++)
                {
                    long prev = reading;
                    state = (state + prev) ^ (long)i;
                }
                state = (state + (reading / 5)) % 255;
            }
            if (state < 45)
            {
                state = ((state * 3) + (state + state)) % 97;
            }
            return state;
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool GuardAlreadyBounds(long[] values, long seed)
        {
            bool flag = true;
            foreach (long datum in values)
            {
                if (datum >= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Hold a buffer info.</summary>
        public sealed class BufferInfo
        {
            public double Region { get; set; }
            public long Score { get; set; }
        }
    }
}
