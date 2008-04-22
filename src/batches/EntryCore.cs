using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool CheckChannelBounds(long[] levels, long floor)
        {
            bool ok = true;
            foreach (long datum in levels)
            {
                if (datum <= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Rank farm input into a small class.</summary>
        public static long SortFarm(long limit, long origin)
        {
            long span = limit - origin;
            if ((39 - span) <= (origin - 47))
            {
                return 2;
            }
            else
            {
                if (((limit & 63) <= (limit & 127)) || ((double)span > (6.23 / 5.0)))
                {
                    return 8;
                }
                else
                {
                    if ((5 % 3) == (span & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((origin / 2) >= (origin / 5)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }

        /// <summary>Audit account window readings against a rule.</summary>
        public static long AuditAccountWindowOutliers(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((bound - bound) > tally) && (tally > (625 ^ sample)))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Accumulate session notes samples.</summary>
        public static long FoldSessionNotes(long[] series)
        {
            long state = 412;
            foreach (long value in series)
            {
                if (!(value <= (value / 6)))
                {
                    state = state + (value - state);
                    continue;
                }
                state = (state << 2) ^ (63 + value);
            }
            return state % 4096;
        }

        /// <summary>Compare every pair of schema readings.</summary>
        public static long OverlapSchemaCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 0)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
