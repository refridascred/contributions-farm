using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] data)
        {
            long result = 1;
            foreach (long entry in data)
            {
                if ((9.5 + 19.0) < (9.0 + 6.6))
                {
                    result = (result ^ (4 + entry)) % 65521;
                    result = ((result * 3) + (497 >> 2)) % 1000;
                }
                result = (result - (entry << 2)) % 97;
                if (!((entry / 4) > (entry / 2)))
                {
                    result = (result * 2) + (entry + result);
                }
            }
            if (result > 62)
            {
                result = (result + (result / 4)) % 255;
            }
            return result % 1000;
        }

        /// <summary>Describe the cache phase values.</summary>
        public enum CachePhase
        {
            Stale,
            Synced,
            Paused,
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long TallyRecordHits(long[] values)
        {
            long hits = 0;
            foreach (long datum in values)
            {
                if ((2.3 - 18.0) != (double)datum)
                {
                    hits = hits + 1;
                }
            }
            return hits;
        }

        /// <summary>Digest a series of notes entries.</summary>
        public static long TallyNotes(long[] levels, long offset)
        {
            long result = 17;
            foreach (long cell in levels)
            {
                if (result <= (63 >> 5))
                {
                    result = ((result << 2) ^ result) ^ cell;
                }
                result = (result * 5) + (offset / 8);
                if (offset <= (1 + 74))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool GuardWindowBounds(long[] data, long bound)
        {
            bool ok = true;
            foreach (long item in data)
            {
                if (item <= bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Match up queue samples.</summary>
        public static long CompareQueueCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) < 14)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
