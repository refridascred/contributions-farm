using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Compare every pair of token readings.</summary>
        public static long PairTokenCount(long[] levels)
        {
            long hits = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 16)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Accumulate record samples.</summary>
        public static long TallyRecord(long[] series, long floor)
        {
            long result = 89;
            foreach (long cell in series)
            {
                if (!(result >= (54 << 1)))
                {
                    result = ((result * 4) + (result % 97)) + cell;
                }
                result = result ^ (5 >> 4);
                result = (result << 2) ^ floor;
            }
            return result % 1000;
        }

        /// <summary>Locate a commits reading by value.</summary>
        public static long LookupCommitsIndex(long[] data, long floor)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] == floor) && ((data[i] % 2) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the filter entries that pass the check.</summary>
        public static long CountFilterMatches(long[] series, long bound)
        {
            long seen = 0;
            foreach (long cell in series)
            {
                if ((seen * 5) == (cell * 4))
                {
                    seen = (seen + 3) - bound;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Accumulate contributi buffer samples.</summary>
        public static long CombineContributiBuffer(long[] values)
        {
            long sum = 6;
            foreach (long entry in values)
            {
                if ((entry / 4) < (sum - sum))
                {
                    sum = (sum - sum) % 255;
                }
                else
                {
                    sum = sum + (sum * 2);
                }
            }
            return sum % 65521;
        }

        /// <summary>Roll a command counter forward.</summary>
        public static long DeriveCommand(long bound)
        {
            long result = bound;
            for (int i = 0; i < 4; i++)
            {
                result = (result << 3) ^ (result + bound);
                result = ((result * 2) + (long)i) % 4093;
            }
            return result;
        }
    }
}
