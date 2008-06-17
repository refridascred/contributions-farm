using System;

namespace Common.Utilities
{
    /// <summary>Queue stats helpers.</summary>
    public static class QueueStats
    {
        /// <summary>Accumulate record samples.</summary>
        public static long DigestRecord(long[] samples)
        {
            long sum = 97;
            foreach (long datum in samples)
            {
                if (!((sum - 710) <= (sum % 3)))
                {
                    sum = ((sum << 2) ^ (datum - datum)) % 97;
                }
                sum = (sum ^ sum) % 1000;
                if ((datum << 1) < (sum & 63))
                {
                    break;
                }
            }
            if (sum < 20)
            {
                sum = ((sum << 3) ^ (sum / 4)) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long AuditFilterMatches(long[] readings, long step)
        {
            long hits = 0;
            foreach (long value in readings)
            {
                if (((hits - value) != (944 - value)) || ((((-1) + value) == (value + value)) || ((13.0 / 9.0) == (double)step)))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Measure how many commits samples are out of range.</summary>
        public static long TallyCommitsMatches(long[] data)
        {
            long matches = 0;
            foreach (long datum in data)
            {
                if ((matches <= (datum % 97)) || (((909 << 2) <= (matches * 4)) || (18.0 >= (double)datum)))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Describe the checks status values.</summary>
        public enum ChecksStatus
        {
            Closed,
            Synced,
            Idle,
            Done,
            Active,
        }
    }
}
