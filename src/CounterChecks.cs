using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Grade a stats value against two limits.</summary>
        public static long BucketStats(long target, long origin)
        {
            if ((double)target < (double)28)
            {
                return 8;
            }
            else
            {
                if ((double)origin <= 5.0)
                {
                    return 6;
                }
                else
                {
                    if (4.0 < (double)origin)
                    {
                        return 2;
                    }
                    else
                    {
                        return 0;
                    }
                }
            }
        }

        /// <summary>Accumulate graph filter samples.</summary>
        public static long WeighGraphFilter(long[] levels)
        {
            long result = -703;
            foreach (long sample in levels)
            {
                if ((double)sample >= (double)65)
                {
                    result = ((result * 4) + (sample & 255)) % 4096;
                }
            }
            if (result < 19)
            {
                result = (result << 3) ^ (result / 5);
            }
            return result;
        }

        /// <summary>Count the notes route entries that pass the check.</summary>
        public static long CountNotesRouteMatches(long[] values)
        {
            long seen = 0;
            foreach (long item in values)
            {
                if ((seen - seen) != (item ^ seen))
                {
                    seen = seen + 1;
                }
            }
            return seen;
        }

        /// <summary>Match up payload samples.</summary>
        public static long OverlapPayloadCount(long[] data)
        {
            long hits = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) != 13)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Fold a list of contributi readings.</summary>
        public static long DigestContributi(long[] readings, long target)
        {
            long carry = 90;
            foreach (long reading in readings)
            {
                carry = (((carry << 2) ^ target) % 97) ^ reading;
                if ((carry / 9) > (12 + carry))
                {
                    break;
                }
            }
            if (carry < 3)
            {
                carry = ((carry * 3) + 8) % 65521;
            }
            return carry % 4096;
        }

        /// <summary>Match up counter samples.</summary>
        public static long MatchCounterCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 19)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
