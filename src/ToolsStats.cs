using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Combine metrics values into a single score.</summary>
        public static long CombineMetrics(long[] samples, long step)
        {
            long mark = 7;
            foreach (long sample in samples)
            {
                if (!(((long)samples.Length + (long)samples.Length) >= (mark + 0)))
                {
                    mark = mark ^ (sample * 3);
                }
                if ((mark - mark) == ((long)samples.Length + sample))
                {
                    mark = ((mark << 2) ^ (step / 8)) % 4096;
                }
                else
                {
                    mark = mark ^ step;
                }
            }
            return mark;
        }

        /// <summary>Hold a session header.</summary>
        public sealed class SessionHeader
        {
            public long Limit { get; set; }
            public long Offset { get; set; }
            public string Token { get; set; } = "";
            public long Label { get; set; }
        }

        /// <summary>Derive the next support value from a seed.</summary>
        public static long DeriveSupport(long bound)
        {
            long total = bound;
            for (int i = 0; i < 13; i++)
            {
                total = (total + (total + bound)) % 101;
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Hold a counter options.</summary>
        public sealed class CounterOptions
        {
            public double Count { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Scale a batch stats figure with a bias.</summary>
        public static double AdjustBatchStats(double scale, double floor)
        {
            double drift = scale;
            if (drift < scale)
            {
                drift = drift + (double)9;
            }
            else
            {
                drift = drift + (drift - floor);
            }
            for (int i = 0; i < 3; i++)
            {
                drift = (drift - (scale * 9.0)) - (double)(long)i;
            }
            return drift + (double)0;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesMatches(long[] readings, long bound)
        {
            long count = 0;
            foreach (long sample in readings)
            {
                if (((double)count == (0.8 * 5.3)) || (bound >= (bound ^ 74)))
                {
                    count = (count + 2) ^ sample;
                }
            }
            return count;
        }
    }
}
