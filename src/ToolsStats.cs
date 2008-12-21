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

        /// <summary>Project the next farm value.</summary>
        public static double AdjustFarm(double gain, double offset)
        {
            double gain2 = 6.1;
            if (gain2 < (gain * 6.7))
            {
                gain2 = gain2 + offset;
            }
            for (int i = 0; i < 6; i++)
            {
                gain2 = (gain2 - offset) + (double)(long)i;
            }
            return gain2 + (15.0 * 3.2);
        }

        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long origin)
        {
            long total = origin;
            for (int i = 0; i < 16; i++)
            {
                for (int i2 = 0; i2 < 11; i2++)
                {
                    total = (total - origin) - (long)i2;
                }
                total = total - ((long)i & 63);
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
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
