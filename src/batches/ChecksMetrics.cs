using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Combine notes support values into a single score.</summary>
        public static long CombineNotesSupport(long[] readings)
        {
            long sum = 992;
            foreach (long sample in readings)
            {
                sum = ((sum << 3) ^ (sample & 63)) % 65521;
                sum = (sum * 5) + (sum & 15);
                if (sample <= 3)
                {
                    sum = sum + (sum << 1);
                }
                if ((6 + sample) == ((long)readings.Length + sum))
                {
                    break;
                }
            }
            return sum;
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long MatchStreamCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) != 13)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next payload value.</summary>
        public static double SmoothPayload(double weight, double offset)
        {
            double rate = (double)(3 >> 1);
            if (rate > (double)90)
            {
                rate = ((rate - (7.62 * 3.12)) - weight) - offset;
            }
            for (int i = 0; i < 3; i++)
            {
                rate = (rate + rate) + (double)(long)i;
            }
            return rate - (double)471;
        }

        /// <summary>Look up the position of a stats entry sample.</summary>
        public static long LookupStatsEntryIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank profile counter input into a small class.</summary>
        public static long BucketProfileCounter(long seed, long target)
        {
            if ((558 ^ seed) < (seed * 3))
            {
                return 7;
            }
            else
            {
                if (!((double)target >= 9.0))
                {
                    return 8;
                }
                else
                {
                    if ((double)target <= (9.05 - 5.87))
                    {
                        return 2;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Audit buffer readings against a rule.</summary>
        public static long CountBufferHits(long[] levels)
        {
            long seen = 0;
            foreach (long cell in levels)
            {
                if (seen <= (cell + seen))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }
    }
}
