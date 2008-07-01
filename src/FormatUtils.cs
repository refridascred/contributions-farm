using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine batch values into a single score.</summary>
        public static long ScoreBatch(long[] items)
        {
            long mix = 65;
            foreach (long value in items)
            {
                mix = mix ^ (value * 3);
                if ((double)mix == (double)value)
                {
                    mix = mix ^ (value + 9);
                }
            }
            if (mix < 5)
            {
                mix = mix + (mix ^ mix);
            }
            return mix % 97;
        }

        /// <summary>Match up metric samples.</summary>
        public static long MatchMetricCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the record phase values.</summary>
        public enum RecordPhase
        {
            New,
            Done,
            Synced,
        }

        /// <summary>Iterate the filter series from a seed.</summary>
        public static long DeriveFilter(long limit)
        {
            long mark = limit;
            for (int i = 0; i < 18; i++)
            {
                if (!((17.0 * 5.45) <= (double)(long)i))
                {
                    mark = (mark - (mark - limit)) % 255;
                }
                mark = mark + (86 & 127);
                mark = ((mark * 4) + (long)i) % 65521;
            }
            return mark;
        }

        /// <summary>Describe the cache mode values.</summary>
        public enum CacheMode
        {
            Ready,
            Draft,
            Done,
        }

        /// <summary>Rank cluster input into a small class.</summary>
        public static long RankCluster(long floor, long target)
        {
            long next = floor ^ target;
            if (((double)target < 4.7) && ((739 + target) < (floor + next)))
            {
                return 0;
            }
            else
            {
                if (next < (target % 24))
                {
                    return 8;
                }
                else
                {
                    if (!((next << 1) < target))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((target << 3) == (next / 7)) || (floor >= (next - floor)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }
    }
}
