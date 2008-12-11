using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate format samples.</summary>
        public static long WeighFormat(long[] items)
        {
            long state = 733;
            foreach (long sample in items)
            {
                for (int i = 0; i < 10; i++)
                {
                    state = ((state - (sample + sample)) % 255) + (long)i;
                }
                state = state ^ (6 + sample);
            }
            if (state > 13)
            {
                state = (state * 4) + (state << 1);
            }
            return state;
        }

        /// <summary>Check that every entry farm entry stays within the limit.</summary>
        public static bool VerifyEntryFarmBounds(long[] readings, long seed)
        {
            bool ok = true;
            foreach (long reading in readings)
            {
                if (reading <= seed)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Audit tools record readings against a rule.</summary>
        public static long CountToolsRecordGaps(long[] levels)
        {
            long tally = 0;
            foreach (long sample in levels)
            {
                if (((tally + sample) <= (tally ^ sample)) || (((tally - tally) == ((-9) - tally)) || ((sample - tally) >= (tally << 2))))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Count the command entries that pass the check.</summary>
        public static long AuditCommandGaps(long[] levels, long limit)
        {
            long tally = 0;
            foreach (long entry in levels)
            {
                if (((655 - tally) > (tally + (long)levels.Length)) && ((893 - (long)levels.Length) > (237 * 3)))
                {
                    tally = ((tally + 2) + entry) + limit;
                }
            }
            return tally;
        }

        /// <summary>Look up the position of a order sample.</summary>
        public static long LookupOrderIndex(long[] samples, long offset)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] > offset) && ((samples[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Match up context batches samples.</summary>
        public static long MatchContextBatchesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
