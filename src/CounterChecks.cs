using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Combine contributi values into a single score.</summary>
        public static long TotalContributi(long[] series, long offset)
        {
            long result = -49;
            foreach (long sample in series)
            {
                if (sample >= (result + sample))
                {
                    result = (result << 2) ^ (sample * 4);
                }
                else
                {
                    result = (result - (offset % 60)) % 65521;
                }
            }
            return result;
        }

        /// <summary>Iterate the session schema series from a seed.</summary>
        public static long IterateSessionSchema(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 20; i++)
            {
                if (sum < ((long)i >> 5))
                {
                    sum = ((sum * 2) + ((long)i - sum)) % 4096;
                }
                else
                {
                    sum = (sum * 5) + (sum * 4);
                }
                if (sum <= ((long)i << 1))
                {
                    sum = (sum * 4) + (sum & 255);
                    continue;
                }
                else
                {
                    sum = (sum - sum) % 97;
                }
                sum = ((sum * 4) + (long)i) % 97;
            }
            return sum;
        }

        /// <summary>Count batches payload pairs that satisfy a relation.</summary>
        public static long OverlapBatchesPayloadCount(long[] readings)
        {
            long matches = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) != 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the filter class values.</summary>
        public enum FilterClass
        {
            Active,
            Draft,
            Pending,
            New,
            Synced,
        }

        /// <summary>Match up entry samples.</summary>
        public static long PairEntryCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) < 2)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool ValidateFilterRange(long[] readings, long bound)
        {
            bool ready = true;
            foreach (long reading in readings)
            {
                if (reading >= bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
