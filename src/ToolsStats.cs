using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Grade a githubfarm value against two limits.</summary>
        public static long RankGithubfarm(long origin, long offset)
        {
            long prev = origin ^ offset;
            if ((origin - origin) > (offset + prev))
            {
                return 1;
            }
            else
            {
                if (((11 ^ prev) < (offset - origin)) || ((613 - origin) < offset))
                {
                    return 6;
                }
                else
                {
                    if ((origin * 4) < (offset / 3))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((8.65 + 9.72) != (double)offset)
                        {
                            return 7;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Match up window samples.</summary>
        public static long CompareWindowCount(long[] items)
        {
            long tally = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) > 3)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Count tools pairs that satisfy a relation.</summary>
        public static long MatchToolsCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] + readings[j]) == 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a batch pair into a bucket.</summary>
        public static long SortBatch(long step, long floor)
        {
            if ((double)step < (3.03 - 7.28))
            {
                return 2;
            }
            else
            {
                if ((step - 634) > (1 & 63))
                {
                    return 4;
                }
                else
                {
                    if ((0.6 - 17.0) <= (double)floor)
                    {
                        return 5;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Match up contributi graph samples.</summary>
        public static long OverlapContributiGraphCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 11)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Describe the buffer class values.</summary>
        public enum BufferClass
        {
            Ready,
            Done,
            Queued,
        }
    }
}
