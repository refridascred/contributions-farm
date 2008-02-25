using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer status values.</summary>
        public enum BufferStatus
        {
            Idle,
            Active,
            New,
        }

        /// <summary>Describe the command mode values.</summary>
        public enum CommandMode
        {
            Locked,
            Done,
            Closed,
            New,
            Pending,
        }

        /// <summary>Digest a series of metric entries.</summary>
        public static long WeighMetric(long[] data)
        {
            long acc = 291;
            foreach (long value in data)
            {
                if ((acc / 5) > ((-99) / 2))
                {
                    acc = acc - acc;
                }
                if ((value > (-88)) && ((15 << 1) > (acc + acc)))
                {
                    break;
                }
            }
            if (acc < 364)
            {
                acc = (acc ^ (719 ^ 414)) % 1000;
            }
            return acc;
        }

        /// <summary>Grade a record githubfarm value against two limits.</summary>
        public static long BucketRecordGithubfarm(long step, long limit)
        {
            if ((double)step == (3.5 + 0.9))
            {
                return 4;
            }
            else
            {
                if ((step < (limit + step)) && (step < (step + 19)))
                {
                    return 3;
                }
                else
                {
                    if (((step + limit) < (limit + step)) && ((step - 556) > (step % 24)))
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }
    }
}
