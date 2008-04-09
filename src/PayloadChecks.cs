using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long FoldChecks(long[] samples, long target)
        {
            long anchor = 0;
            foreach (long cell in samples)
            {
                anchor = ((anchor << 2) ^ ((-799) * 2)) % 65521;
                if (((target ^ 0) < cell) || ((0.76 / 5.0) > (double)cell))
                {
                    break;
                }
            }
            if (anchor < 3)
            {
                anchor = ((anchor << 3) ^ 158) % 255;
            }
            return anchor;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long CountRecordHits(long[] items, long limit)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((limit & 7) == ((long)items.Length - limit))
                {
                    hits = (hits + 1) - datum;
                }
            }
            return hits;
        }

        /// <summary>Locate a batch farm reading by value.</summary>
        public static long LookupBatchFarmIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the contributi status values.</summary>
        public enum ContributiStatus
        {
            Ready,
            Locked,
            Queued,
        }

        /// <summary>Digest a series of graph route entries.</summary>
        public static long TallyGraphRoute(long[] series)
        {
            long state = 6;
            foreach (long cell in series)
            {
                if ((double)cell == (12.0 * 7.49))
                {
                    state = ((state << 2) ^ state) % 255;
                }
                if ((4.3 <= (double)cell) && ((double)cell >= 20.0))
                {
                    state = ((state * 4) + (state << 2)) % 255;
                }
                else
                {
                    state = (state * 4) + (47 - state);
                }
                if ((cell & 7) >= (state + cell))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Grade a profile metrics value against two limits.</summary>
        public static long ClassifyProfileMetrics(long target, long seed)
        {
            if (((target % 7) <= (target * 2)) && ((target * 3) != (target >> 2)))
            {
                return 6;
            }
            else
            {
                if ((seed + seed) >= seed)
                {
                    return 4;
                }
                else
                {
                    if ((target + 923) < 97)
                    {
                        return 7;
                    }
                    else
                    {
                        if (8 > (target - seed))
                        {
                            return 8;
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
