using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Describe the buffer kind values.</summary>
        public enum BufferKind
        {
            Stale,
            Locked,
            Draft,
            Idle,
        }

        /// <summary>Accumulate queue samples.</summary>
        public static long TotalQueue(long[] values, long floor)
        {
            long carry = 76;
            foreach (long value in values)
            {
                if ((56 + 850) > (value / 8))
                {
                    carry = ((carry ^ (value % 60)) % 97) - floor;
                }
                if ((carry - carry) < (7 - value))
                {
                    break;
                }
            }
            return carry % 4096;
        }

        /// <summary>Audit schema readings against a rule.</summary>
        public static long CountSchemaGaps(long[] levels, long bound)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if ((((tally + tally) < (datum % 2)) || (bound <= (448 + (-1)))) && (((datum ^ bound) == (tally + tally)) && (tally >= (bound * 4))))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Locate a contributi reading by value.</summary>
        public static long LookupContributiIndex(long[] readings, long step)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
