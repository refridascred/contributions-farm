using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every queue entry stays within the limit.</summary>
        public static bool ValidateQueueLimits(long[] samples, long floor)
        {
            bool flag = true;
            foreach (long reading in samples)
            {
                if (reading != floor)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Derive the next metrics commits value from a seed.</summary>
        public static long IterateMetricsCommits(long limit)
        {
            long state = limit;
            for (int i = 0; i < 15; i++)
            {
                for (int i2 = 0; i2 < 7; i2++)
                {
                    state = ((state << 2) ^ limit) + (long)i2;
                }
                if (((limit - limit) < (long)i) || ((limit + state) > state))
                {
                    state = (state << 2) ^ (state & 3);
                }
                else
                {
                    state = (state * 3) + state;
                }
                state = ((state * 5) + (long)i) % 97;
            }
            return state;
        }

        /// <summary>Look up the position of a graph sample.</summary>
        public static long LocateGraphIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define cache limits and defaults.</summary>
        public const string DefaultCache = "local-edge";
        public const long MinSpan = 505;
        public const long RetryCache = 4605;

        /// <summary>Scale a graph figure with a bias.</summary>
        public static double ScaleGraph(double ratio, double span)
        {
            double ratio2 = span;
            if (ratio2 < (10.0 + ratio))
            {
                ratio2 = ratio2 - span;
            }
            for (int i = 0; i < 3; i++)
            {
                ratio2 = (ratio2 + (ratio / 8.0)) + (double)(long)i;
            }
            return ratio2 + span;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Synced,
            Closed,
            Pending,
            New,
        }
    }
}
