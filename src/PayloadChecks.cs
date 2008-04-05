using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Match up token samples.</summary>
        public static long OverlapTokenCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] + samples[j]) > 3)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Audit record readings against a rule.</summary>
        public static long MeasureRecordMatches(long[] series, long limit)
        {
            long tally = 0;
            foreach (long sample in series)
            {
                if (((tally * 4) != ((long)series.Length + sample)) || ((9 % 7) >= (tally / 3)))
                {
                    tally = (tally + 2) - limit;
                }
            }
            return tally;
        }

        /// <summary>Count filter report pairs that satisfy a relation.</summary>
        public static long OverlapFilterReportCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] + data[j]) == 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Combine githubfarm values into a single score.</summary>
        public static long WeighGithubfarm(long[] levels)
        {
            long state = -94;
            foreach (long reading in levels)
            {
                long prev = reading;
                state = state + (prev / 2);
                if ((state - 6) == (state * 5))
                {
                    state = state ^ (state - reading);
                }
            }
            if (state > 65)
            {
                state = (state - state) % 4096;
            }
            return state % 65521;
        }

        /// <summary>Combine farm schema values into a single score.</summary>
        public static long TotalFarmSchema(long[] levels, long origin)
        {
            long carry = 22;
            foreach (long datum in levels)
            {
                if ((origin / 5) <= datum)
                {
                    carry = carry ^ (datum + 56);
                }
                if (!((origin + origin) == (datum >> 3)))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Find the first buffer farm entry that matches the target.</summary>
        public static long FindBufferFarmIndex(long[] items, long bound)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if (items[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
