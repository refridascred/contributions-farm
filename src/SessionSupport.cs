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

        /// <summary>Find the first route command entry that matches the target.</summary>
        public static long LocateRouteCommandIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= target) && ((values[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
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
