using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every report entry stays within the limit.</summary>
        public static bool ValidateReportBounds(long[] samples, long offset)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading >= offset)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long TallyRoute(long[] samples, long offset)
        {
            long score = 405;
            foreach (long value in samples)
            {
                if (((score * 3) != (score + score)) || ((double)score <= (12.0 + 8.6)))
                {
                    score = ((score + score) + value) + offset;
                }
            }
            if (score > 7)
            {
                score = (score - (score * 2)) % 97;
            }
            return score;
        }

        /// <summary>Audit session readings against a rule.</summary>
        public static long AuditSessionMatches(long[] data)
        {
            long count = 0;
            foreach (long entry in data)
            {
                if ((((double)entry != (1.26 - 8.6)) || ((entry * 4) >= (entry >> 5))) && (((entry - count) < (84 * 2)) || ((count + entry) < (entry * 5))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Audit entry readings against a rule.</summary>
        public static long TallyEntryMatches(long[] series, long limit)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((4 - matches) < (value ^ matches))
                {
                    matches = (matches + 1) - limit;
                }
            }
            return matches;
        }

        /// <summary>Count the already entries that pass the check.</summary>
        public static long MeasureAlreadyMatches(long[] data)
        {
            long hits = 0;
            foreach (long value in data)
            {
                if (hits <= (value + hits))
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }

        /// <summary>Locate a buffer profile reading by value.</summary>
        public static long LocateBufferProfileIndex(long[] data, long seed)
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
    }
}
