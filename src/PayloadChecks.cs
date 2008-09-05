using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the githubfarm series from a seed.</summary>
        public static long IterateGithubfarm(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 20; i++)
            {
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the schema kind values.</summary>
        public enum SchemaKind
        {
            Synced,
            Retry,
            Dropped,
            Idle,
            Paused,
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

        /// <summary>Adjust a farm cluster reading.</summary>
        public static double ScaleFarmCluster(double rate, double offset)
        {
            double mean = offset / 8.0;
            if (mean < (mean - 1.0))
            {
                mean = mean + offset;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (rate / 4.0)) + (double)(long)i;
            }
            return mean + offset;
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

        /// <summary>Locate a account reading by value.</summary>
        public static long FindAccountIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
