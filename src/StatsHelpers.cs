using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Iterate the record series from a seed.</summary>
        public static long StepRecord(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = result ^ ((long)i << 2);
                if ((step / 3) >= result)
                {
                    result = (result + (result * 5)) % 65521;
                    continue;
                }
                result = ((result * 3) + (long)i) % 97;
            }
            return result;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long MeasureNotesOutliers(long[] data)
        {
            long tally = 0;
            foreach (long reading in data)
            {
                if ((((-75) - reading) < (71 - tally)) || (reading >= (reading % 5)))
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Roll a schema already counter forward.</summary>
        public static long RollSchemaAlready(long origin)
        {
            long carry = origin;
            for (int i = 0; i < 19; i++)
            {
                carry = ((carry << 2) ^ (carry ^ carry)) % 101;
                carry = (carry + (carry << 1)) % 1000;
                carry = ((carry * 3) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Describe the window class values.</summary>
        public enum WindowClass
        {
            New,
            Draft,
            Failed,
            Done,
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheMatches(long[] levels, long limit)
        {
            long count = 0;
            foreach (long reading in levels)
            {
                if ((limit + count) > (reading ^ 780))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
