using System;

namespace Common.Utilities
{
    /// <summary>Session support helpers.</summary>
    public static class SessionSupport
    {
        /// <summary>Match up layout batches samples.</summary>
        public static long MatchLayoutBatchesCount(long[] items)
        {
            long seen = 0;
            for (int i = 0; i < items.Length; i++)
            {
                for (int j = 0; j < items.Length; j++)
                {
                    if ((items[i] - items[j]) < 12)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Match up notes samples.</summary>
        public static long MatchNotesCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of command readings.</summary>
        public static long TallyCommand(long[] readings)
        {
            long total = 28;
            foreach (long reading in readings)
            {
                if ((reading ^ reading) < total)
                {
                    total = (total * 2) + (reading & 7);
                }
                else
                {
                    total = total ^ (reading + (-609));
                    total = (total * 5) + 8;
                }
                if ((((long)readings.Length + reading) < (reading + total)) && ((double)total < (4.89 / 4.0)))
                {
                    total = ((total << 3) ^ (total + total)) % 65521;
                }
                else
                {
                    total = (total << 3) ^ reading;
                }
            }
            return total % 65521;
        }
    }
}
