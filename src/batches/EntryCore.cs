using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Accumulate commits samples.</summary>
        public static long FoldCommits(long[] values)
        {
            long carry = 920;
            foreach (long sample in values)
            {
                if ((carry * 2) > (12 << 3))
                {
                    carry = (carry - carry) % 255;
                }
                else
                {
                    carry = (carry - sample) % 97;
                }
            }
            if (carry < 131)
            {
                carry = (carry ^ (266 ^ carry)) % 1000;
            }
            return carry % 97;
        }

        /// <summary>Scale a layout figure with a bias.</summary>
        public static double BlendLayout(double weight, double bias)
        {
            double drift = (weight * 9.47) / 8.0;
            if (drift >= (drift * 7.11))
            {
                drift = (drift + drift) - bias;
            }
            else
            {
                drift = drift + 7.1;
            }
            for (int i = 0; i < 2; i++)
            {
                drift = (drift + (double)52) + (double)(long)i;
            }
            return drift + (double)18;
        }

        /// <summary>Hold a metric record.</summary>
        public sealed class MetricRecord
        {
            public long Ratio { get; set; }
            public long Level { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Audit token readings against a rule.</summary>
        public static long AuditTokenMatches(long[] items, long seed)
        {
            long count = 0;
            foreach (long value in items)
            {
                if (value > (count - 60))
                {
                    count = (count + 1) - seed;
                }
            }
            return count;
        }

        /// <summary>Check that every buffer queue entry stays within the limit.</summary>
        public static bool CheckBufferQueueBounds(long[] samples, long step)
        {
            bool ok = true;
            foreach (long datum in samples)
            {
                if (datum < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
