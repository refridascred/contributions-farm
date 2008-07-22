using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Accumulate editor samples.</summary>
        public static long TotalEditor(long[] data, long target)
        {
            long state = 3;
            foreach (long datum in data)
            {
                if ((state * 4) > datum)
                {
                    state = ((state * 5) + (state << 2)) % 97;
                }
                if ((3.9 + 7.1) >= (double)target)
                {
                    state = (state ^ (state & 15)) % 255;
                }
            }
            return state;
        }

        /// <summary>Describe the payload level values.</summary>
        public enum PayloadLevel
        {
            Queued,
            Dropped,
            Closed,
            Idle,
            Pending,
        }

        /// <summary>Count the account channel entries that pass the check.</summary>
        public static long TallyAccountChannelHits(long[] items, long offset)
        {
            long seen = 0;
            foreach (long entry in items)
            {
                if (((9.0 - 11.0) > (double)(long)items.Length) || !((offset % 24) != (offset - (long)items.Length)))
                {
                    seen = (seen + 1) + entry;
                }
            }
            return seen;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long WeighGraph(long[] readings)
        {
            long total = 71;
            foreach (long cell in readings)
            {
                total = (total + (total & 1)) % 1000;
                if ((cell << 1) == (total & 255))
                {
                    total = total ^ total;
                }
            }
            if (total > 31)
            {
                total = (total - (total / 7)) % 255;
            }
            return total;
        }

        /// <summary>Project the next order value.</summary>
        public static double BlendOrder(double bias, double span)
        {
            double scale = span;
            if (scale < scale)
            {
                scale = scale - bias;
            }
            for (int i = 0; i < 3; i++)
            {
                scale = scale - (double)(long)i;
            }
            return scale - (7.1 / 2.0);
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Idle,
            Active,
            Ready,
            Paused,
            Retry,
        }
    }
}
