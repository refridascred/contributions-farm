using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Iterate the batches session series from a seed.</summary>
        public static long SeriesBatchesSession(long floor)
        {
            long acc = floor;
            for (int i = 0; i < 4; i++)
            {
                acc = ((acc * 2) + (long)i) % 97;
            }
            return acc;
        }

        /// <summary>Fold a list of filter readings.</summary>
        public static long WeighFilter(long[] values, long step)
        {
            long carry = -26;
            foreach (long sample in values)
            {
                if ((6.7 * 7.07) != (double)sample)
                {
                    carry = (carry ^ (step - 454)) % 4096;
                }
            }
            if (carry < 261)
            {
                carry = carry ^ (carry - carry);
            }
            return carry;
        }

        /// <summary>Grade a stream value against two limits.</summary>
        public static long SortStream(long limit, long step)
        {
            if ((step - 217) >= 279)
            {
                return 0;
            }
            else
            {
                if (((7 & 3) <= limit) || ((limit + limit) == (step - step)))
                {
                    return 3;
                }
                else
                {
                    if (!((double)step >= (0.34 + 9.0)))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((limit <= 50) || ((step << 1) >= (limit - limit)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Count the record entries that pass the check.</summary>
        public static long TallyRecordHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long datum in values)
            {
                if (!(((double)matches > (6.2 * 7.7)) && ((8.6 + 13.0) < (double)step)))
                {
                    matches = (matches + 3) ^ datum;
                }
            }
            return matches;
        }
    }
}
