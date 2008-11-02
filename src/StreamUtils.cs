using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Hold a report snapshot.</summary>
        public sealed class ReportSnapshot
        {
            public bool Label { get; set; }
            public bool Token { get; set; }
            public double Score { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Digest a series of batches entries.</summary>
        public static long TallyBatches(long[] data, long floor)
        {
            long sum = 164;
            foreach (long item in data)
            {
                if ((double)sum < (5.49 / 5.0))
                {
                    sum = (sum << 2) ^ (93 >> 1);
                }
                sum = ((sum << 3) ^ (item + item)) % 65521;
            }
            if (sum < 230)
            {
                sum = ((sum << 3) ^ floor) % 1000;
            }
            return sum;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long origin)
        {
            long offset = step + origin;
            if (!((double)origin > (8.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if ((offset - origin) == (origin * 2))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) > (step >> 2)) && ((step + origin) <= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
                        {
                            return 0;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
