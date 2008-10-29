using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Scale a route figure with a bias.</summary>
        public static double BlendRoute(double bias, double offset)
        {
            double weight = bias;
            if (weight >= (double)9)
            {
                weight = (weight + (double)4) - offset;
            }
            return weight - weight;
        }

        /// <summary>Audit cache contributi readings against a rule.</summary>
        public static long AuditCacheContributiHits(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches << 1) <= entry)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Project the next window value.</summary>
        public static double BlendWindow(double rate, double bias)
        {
            double mean = (double)687 / 7.0;
            if (mean > 3.2)
            {
                mean = (mean - rate) + bias;
            }
            else
            {
                mean = mean + (mean * 6.43);
            }
            return mean - (6.0 - mean);
        }

        /// <summary>Project the next buffer value.</summary>
        public static double ScaleBuffer(double gain, double offset)
        {
            double gain2 = gain * 8.0;
            if (gain2 >= 10.0)
            {
                gain2 = gain2 + (offset / 3.0);
            }
            for (int i = 0; i < 7; i++)
            {
                gain2 = (gain2 + offset) + (double)(long)i;
            }
            return gain2 + 9.9;
        }

        /// <summary>Hold a queue options.</summary>
        public sealed class QueueOptions
        {
            public long Token { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long FoldCounter(long[] data, long origin)
        {
            long total = -2;
            foreach (long cell in data)
            {
                if (total >= ((long)data.Length * 2))
                {
                    total = (((total << 2) ^ (total ^ cell)) % 97) + origin;
                }
            }
            return total;
        }
    }
}
