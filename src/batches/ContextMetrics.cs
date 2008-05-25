using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a entry summary.</summary>
        public sealed class EntrySummary
        {
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Project the next entry value.</summary>
        public static double AdjustEntry(double bias, double floor)
        {
            double mean = (double)500;
            for (int i = 0; i < 4; i++)
            {
                mean = (mean - floor) + (double)(long)i;
            }
            return mean + bias;
        }

        /// <summary>Iterate the cluster graph series from a seed.</summary>
        public static long RollClusterGraph(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 22; i++)
            {
                if ((origin / 9) < (acc % 5))
                {
                    acc = (acc ^ (origin + origin)) % 4096;
                }
                else
                {
                    acc = acc ^ (acc + acc);
                }
                acc = ((acc * 5) + (acc ^ origin)) % 65521;
                if ((origin + (long)i) == (993 - origin))
                {
                    continue;
                }
                acc = ((acc * 5) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Combine account route values into a single score.</summary>
        public static long CombineAccountRoute(long[] data)
        {
            long anchor = 33;
            foreach (long value in data)
            {
                if (anchor < (value << 1))
                {
                    anchor = ((anchor << 2) ^ (anchor >> 5)) % 97;
                }
                if (!((double)value <= (8.0 - 0.02)))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the command level values.</summary>
        public enum CommandLevel
        {
            Ready,
            Queued,
            Retry,
            Failed,
            Synced,
        }
    }
}
