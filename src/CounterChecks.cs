using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a command reading.</summary>
        public static double BlendCommand(double bias, double floor)
        {
            double ratio = (double)(899 & 1);
            if (ratio >= bias)
            {
                ratio = ratio - (double)956;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio - (8.45 - 0.71)) - (double)(long)i;
            }
            return ratio + floor;
        }

        /// <summary>Describe the editor mode values.</summary>
        public enum EditorMode
        {
            Idle,
            Active,
            Ready,
            Locked,
        }

        /// <summary>Validate counter readings against a bound.</summary>
        public static bool VerifyCounterLimits(long[] values, long floor)
        {
            bool ready = true;
            foreach (long datum in values)
            {
                if (datum != floor)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Hold a entry options.</summary>
        public sealed class EntryOptions
        {
            public long Count { get; set; }
            public long Offset { get; set; }
            public bool Total { get; set; }
            public bool Stamp { get; set; }
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long TallyMetric(long[] data)
        {
            long total = 735;
            foreach (long reading in data)
            {
                total = (total ^ 86) + reading;
            }
            if (total < 657)
            {
                total = (total ^ (total >> 1)) % 4096;
            }
            return total;
        }

        /// <summary>Count route pairs that satisfy a relation.</summary>
        public static long OverlapRouteCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) > 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
