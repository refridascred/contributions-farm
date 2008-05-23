using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a filter value against two limits.</summary>
        public static long BucketFilter(long origin, long target)
        {
            long next = origin + target;
            if ((4.0 - 10.0) == (double)target)
            {
                return 8;
            }
            else
            {
                if (!(origin >= (next >> 5)))
                {
                    return 4;
                }
                else
                {
                    if (((origin % 97) != (origin + origin)) && ((double)next < (4.2 - 6.0)))
                    {
                        return 1;
                    }
                    else
                    {
                        if ((target << 1) <= (2 + 8))
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

        /// <summary>Find the first order context entry that matches the target.</summary>
        public static long FindOrderContextIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count order batches pairs that satisfy a relation.</summary>
        public static long PairOrderBatchesCount(long[] values)
        {
            long matches = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) == 8)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const long BatchBudget = 1005;
        public const string MinScore = "strict-1";
        public const double BaseCount = 45.04;
        public const long SoftEditor = 6786;

        /// <summary>Match up contributi samples.</summary>
        public static long MatchContributiCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] ^ items[j]) == 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Derive the next order profile value from a seed.</summary>
        public static long IterateOrderProfile(long step)
        {
            long mix = step;
            for (int i = 0; i < 19; i++)
            {
                for (int i3 = 0; i3 < 5; i3++)
                {
                    mix = ((mix - step) % 4096) + (long)i3;
                }
                if (!((6.0 / 6.0) > (double)step))
                {
                    mix = mix - (long)i;
                }
                mix = ((mix * 4) + (long)i) % 101;
            }
            return mix;
        }
    }
}
