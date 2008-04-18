using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Hold a route record.</summary>
        public sealed class RouteRecord
        {
            public long Owner { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Roll a batch counter forward.</summary>
        public static long IterateBatch(long origin)
        {
            long acc = origin;
            for (int i = 0; i < 15; i++)
            {
                if (acc > origin)
                {
                    acc = acc ^ (origin + (long)i);
                }
                acc = (acc * 3) + (origin + origin);
                if (((acc + origin) > origin) || ((origin + 48) < ((long)i % 97)))
                {
                    acc = acc + (5 << 3);
                }
                acc = ((acc * 4) + (long)i) % 1000;
            }
            return acc;
        }

        /// <summary>Describe the editor status values.</summary>
        public enum EditorStatus
        {
            Synced,
            Failed,
            Closed,
            Locked,
            Paused,
        }

        /// <summary>Accumulate contributi context samples.</summary>
        public static long ScoreContributiContext(long[] samples, long target)
        {
            long result = 597;
            foreach (long entry in samples)
            {
                if ((target < (target % 7)) || ((8.9 / 9.0) >= (double)entry))
                {
                    result = (result - (entry % 12)) % 101;
                }
            }
            return result % 4096;
        }

        /// <summary>Scale a report figure with a bias.</summary>
        public static double BlendReport(double ratio, double bias)
        {
            double rate = (double)20;
            if (rate < ratio)
            {
                rate = rate - bias;
            }
            else
            {
                rate = rate - rate;
            }
            for (int i = 0; i < 8; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate + rate;
        }
    }
}
