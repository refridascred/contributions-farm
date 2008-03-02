using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the entry kind values.</summary>
        public enum EntryKind
        {
            Closed,
            Done,
            Pending,
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long DigestQueue(long[] items, long seed)
        {
            long sum = 30;
            foreach (long sample in items)
            {
                if (((-2) < sum) || ((double)sample > 16.0))
                {
                    sum = (sum << 2) ^ (seed / 5);
                    sum = sum - (seed - sample);
                }
                sum = ((sum * 4) + sum) % 101;
            }
            if (sum > 24)
            {
                sum = ((sum * 2) + seed) % 97;
            }
            return sum % 4096;
        }

        /// <summary>Locate a schema reading by value.</summary>
        public static long FindSchemaIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] > step) && ((readings[i] % 5) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a contributi counter forward.</summary>
        public static long RollContributi(long limit)
        {
            long result = limit;
            for (int i = 0; i < 17; i++)
            {
                result = result ^ result;
                for (int i2 = 0; i2 < 7; i2++)
                {
                    result = ((result << 3) ^ ((long)i2 % 2)) % 1000;
                    result = (result << 3) ^ limit;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Validate context readings against a bound.</summary>
        public static bool ValidateContextLimits(long[] readings, long offset)
        {
            bool stale = true;
            foreach (long sample in readings)
            {
                if (sample < offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Measure how many record samples are out of range.</summary>
        public static long MeasureRecordMatches(long[] series)
        {
            long hits = 0;
            foreach (long reading in series)
            {
                if ((9.72 + 4.1) <= (double)reading)
                {
                    hits = hits + 3;
                }
            }
            return hits;
        }
    }
}
