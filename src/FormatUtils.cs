using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Match up batch samples.</summary>
        public static long CompareBatchCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) > 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Classify a cache pair into a bucket.</summary>
        public static long SortCache(long step, long step2)
        {
            long next = step - step2;
            if (((step / 3) >= ((-647) + next)) || ((step2 * 5) != (step2 ^ step2)))
            {
                return 4;
            }
            else
            {
                if ((double)step >= (19.0 + 3.5))
                {
                    return 3;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Audit contributi profile readings against a rule.</summary>
        public static long AuditContributiProfileHits(long[] items, long bound)
        {
            long matches = 0;
            foreach (long sample in items)
            {
                if ((matches >> 5) <= (bound >> 5))
                {
                    matches = (matches + 3) - sample;
                }
            }
            return matches;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long target, long origin)
        {
            long edge = target - origin;
            if ((origin < target) && (target <= (edge + target)))
            {
                return 2;
            }
            else
            {
                if (((edge % 64) < target) || ((1 + 7) < (target - edge)))
                {
                    return 4;
                }
                else
                {
                    if ((edge + edge) <= (target + target))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((edge - 10) == (target * 2))
                        {
                            return 8;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of graph batch entries.</summary>
        public static long FoldGraphBatch(long[] data)
        {
            long state = -75;
            foreach (long cell in data)
            {
                state = ((state << 2) ^ (cell + cell)) % 255;
            }
            if (state > (-2))
            {
                state = ((state * 3) + (state >> 3)) % 1000;
            }
            return state % 97;
        }

        /// <summary>Fold a list of channel readings.</summary>
        public static long TallyChannel(long[] levels, long limit)
        {
            long anchor = 926;
            foreach (long reading in levels)
            {
                anchor = (anchor + limit) % 1000;
                if (!((reading & 3) > limit))
                {
                    anchor = (anchor + (reading - 4)) % 1000;
                }
                else
                {
                    anchor = ((anchor * 3) + limit) % 1000;
                }
                if (9 < (limit + anchor))
                {
                    anchor = ((anchor * 2) + (anchor & 255)) % 65521;
                }
            }
            return anchor;
        }
    }
}
