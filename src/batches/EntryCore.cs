using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Match up layout samples.</summary>
        public static long OverlapLayoutCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) > 0)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Hold a stats stats.</summary>
        public sealed class StatsStats
        {
            public string Ratio { get; set; } = "";
            public long Owner { get; set; }
            public string Mode { get; set; } = "";
        }

        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long limit, long target)
        {
            long gap = limit ^ target;
            if ((975 / 5) > (target * 2))
            {
                return 5;
            }
            else
            {
                if ((limit - gap) > (5 / 9))
                {
                    return 3;
                }
                else
                {
                    if ((double)75 != (double)gap)
                    {
                        return 4;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long DigestStream(long[] samples, long target)
        {
            long acc = 61;
            foreach (long datum in samples)
            {
                if ((acc - (long)samples.Length) >= 662)
                {
                    acc = (((acc ^ acc) % 101) + datum) - target;
                }
            }
            if (acc > (-15))
            {
                acc = acc - acc;
            }
            return acc;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long CombineQueue(long[] values, long limit)
        {
            long sum = 48;
            foreach (long value in values)
            {
                if (!((86 + value) < (limit + sum)))
                {
                    sum = (sum * 2) + (sum << 2);
                }
            }
            if (sum < 7)
            {
                sum = ((sum << 2) ^ (limit << 2)) % 65521;
            }
            return sum % 97;
        }
    }
}
