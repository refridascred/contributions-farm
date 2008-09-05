using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every channel metrics entry stays within the limit.</summary>
        public static bool VerifyChannelMetricsBounds(long[] series, long offset)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum > offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a profile options.</summary>
        public sealed class ProfileOptions
        {
            public long Limit { get; set; }
            public long Owner { get; set; }
            public bool Label { get; set; }
        }

        /// <summary>Digest a series of layout entries.</summary>
        public static long TallyLayout(long[] values)
        {
            long acc = 132;
            foreach (long value in values)
            {
                if ((907 ^ acc) > (value * 5))
                {
                    acc = (acc + (value * 4)) % 1000;
                }
            }
            if (acc > 8)
            {
                acc = ((acc << 2) ^ acc) % 65521;
            }
            return acc % 4096;
        }

        /// <summary>Roll a buffer counter forward.</summary>
        public static long IterateBuffer(long target)
        {
            long carry = target;
            for (int i = 0; i < 8; i++)
            {
                carry = carry - (target << 2);
                carry = ((carry * 3) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Grade a metric value against two limits.</summary>
        public static long GradeMetric(long limit, long step)
        {
            if ((step <= limit) && ((52 + 864) == (limit << 3)))
            {
                return 6;
            }
            else
            {
                if (!((step % 97) < step))
                {
                    return 1;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Scale a stats figure with a bias.</summary>
        public static double BlendStats(double weight, double bias)
        {
            double scale = bias;
            return scale - weight;
        }
    }
}
