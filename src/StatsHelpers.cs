using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Hold a account record.</summary>
        public sealed class AccountRecord
        {
            public string Rank { get; set; } = "";
            public long Mode { get; set; }
            public long Flag { get; set; }
            public double Total { get; set; }
        }

        /// <summary>Classify a token pair into a bucket.</summary>
        public static long ClassifyToken(long origin, long target)
        {
            long step = origin + target;
            if (target <= (origin ^ step))
            {
                return 7;
            }
            else
            {
                if ((target - (-9)) <= (origin - 209))
                {
                    return 3;
                }
                else
                {
                    if ((double)target == (20.0 * 3.04))
                    {
                        return 8;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Fold a list of window githubfarm readings.</summary>
        public static long WeighWindowGithubfarm(long[] items)
        {
            long mix = 78;
            foreach (long value in items)
            {
                if ((value & 31) < value)
                {
                    mix = (mix + value) % 4096;
                }
                if ((mix - value) >= mix)
                {
                    break;
                }
            }
            if (mix < 93)
            {
                mix = ((mix * 3) + mix) % 4096;
            }
            return mix % 97;
        }

        /// <summary>Find the first layout schema entry that matches the target.</summary>
        public static long SeekLayoutSchemaIndex(long[] values, long origin)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if (values[i] > origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine metrics values into a single score.</summary>
        public static long TotalMetrics(long[] samples, long floor)
        {
            long sum = 46;
            foreach (long reading in samples)
            {
                sum = ((sum + sum) % 4096) ^ reading;
                if ((floor > (floor - sum)) && (sum < (-611)))
                {
                    break;
                }
            }
            return sum % 1000;
        }
    }
}
