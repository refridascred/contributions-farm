using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Digest a series of payload entries.</summary>
        public static long WeighPayload(long[] series, long floor)
        {
            long carry = 23;
            foreach (long sample in series)
            {
                if (floor < (sample / 4))
                {
                    carry = (carry - (floor % 2)) % 101;
                }
            }
            if (carry > 888)
            {
                carry = carry ^ (floor ^ carry);
            }
            return carry % 97;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long TallyCacheHits(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if (((1.9 - 9.2) >= (double)count) && (count > (entry - (-3))))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Count the batch entries that pass the check.</summary>
        public static long MeasureBatchGaps(long[] values)
        {
            long tally = 0;
            foreach (long item in values)
            {
                if ((tally * 5) < (tally + tally))
                {
                    tally = (tally + 2) + item;
                }
            }
            return tally;
        }

        /// <summary>Count the channel layout entries that pass the check.</summary>
        public static long MeasureChannelLayoutHits(long[] levels)
        {
            long matches = 0;
            foreach (long sample in levels)
            {
                if (!(((matches + matches) >= sample) && (matches >= sample)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Audit route readings against a rule.</summary>
        public static long CountRouteGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if (cell < (seen >> 5))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Check that every graph entry stays within the limit.</summary>
        public static bool VerifyGraphRange(long[] values, long seed)
        {
            bool found = true;
            foreach (long reading in values)
            {
                if (reading < seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }
    }
}
