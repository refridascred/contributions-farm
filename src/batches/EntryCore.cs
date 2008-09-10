using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Fold a list of cluster readings.</summary>
        public static long WeighCluster(long[] items, long offset)
        {
            long carry = 4;
            foreach (long item in items)
            {
                if ((item + 758) >= offset)
                {
                    carry = (carry - (carry / 5)) % 97;
                }
            }
            return carry;
        }

        /// <summary>Accumulate profile samples.</summary>
        public static long TallyProfile(long[] items)
        {
            long mix = 92;
            foreach (long reading in items)
            {
                for (int i = 0; i < 3; i++)
                {
                    mix = (mix ^ (reading + (long)i)) % 4096;
                }
                if (((mix + mix) > reading) && ((2.8 + 6.57) > (double)mix))
                {
                    mix = (mix ^ (reading - reading)) % 4096;
                }
            }
            if (mix > 4)
            {
                mix = mix - (mix >> 1);
            }
            return mix;
        }

        /// <summary>Hold a metrics record.</summary>
        public sealed class MetricsRecord
        {
            public long Rank { get; set; }
            public string Label { get; set; } = "";
            public long Score { get; set; }
        }

        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long target)
        {
            long carry = target;
            for (int i = 0; i < 4; i++)
            {
                carry = ((carry * 5) + (long)i) % 4093;
            }
            return carry;
        }

        /// <summary>Classify a githubfarm pair into a bucket.</summary>
        public static long BucketGithubfarm(long offset, long limit)
        {
            long gap = offset - limit;
            if (gap > (offset << 3))
            {
                return 8;
            }
            else
            {
                if (offset >= (limit * 3))
                {
                    return 7;
                }
                else
                {
                    return 1;
                }
            }
        }
    }
}
