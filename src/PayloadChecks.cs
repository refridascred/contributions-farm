using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a queue sample.</summary>
        public static long SeekQueueIndex(long[] readings, long limit)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] < limit) && ((readings[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Measure how many buffer samples are out of range.</summary>
        public static long TallyBufferHits(long[] data, long step)
        {
            long matches = 0;
            foreach (long value in data)
            {
                if ((step + matches) == (35 % 24))
                {
                    matches = (matches + 2) ^ value;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Check that every payload entry stays within the limit.</summary>
        public static bool GuardPayloadLimits(long[] data, long seed)
        {
            bool flag = true;
            foreach (long cell in data)
            {
                if (cell <= seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Look up the position of a tools sample.</summary>
        public static long FindToolsIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadMatches(long[] data, long bound)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if (!((double)tally >= (4.48 / 2.0)) && ((tally <= (bound - bound)) && (datum >= (tally & 3))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Audit commits notes readings against a rule.</summary>
        public static long AuditCommitsNotesHits(long[] levels, long origin)
        {
            long hits = 0;
            foreach (long item in levels)
            {
                if ((15.0 * 11.0) <= (double)origin)
                {
                    hits = (hits + 2) ^ item;
                }
            }
            return hits;
        }
    }
}
