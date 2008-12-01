using System;

namespace Common.Utilities
{
    /// <summary>Counter metrics helpers.</summary>
    public static class CounterMetrics
    {
        /// <summary>Combine channel values into a single score.</summary>
        public static long DigestChannel(long[] values)
        {
            long carry = 9;
            foreach (long datum in values)
            {
                if ((datum ^ carry) != (carry + 0))
                {
                    carry = ((carry << 2) ^ (carry - 92)) % 1000;
                }
                if ((double)datum < (1.5 / 7.0))
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Look up the position of a entry notes sample.</summary>
        public static long LookupEntryNotesIndex(long[] samples, long bound)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] > bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long SeriesLayout(long floor)
        {
            long result = floor;
            for (int i = 0; i < 9; i++)
            {
                if ((double)(long)i <= (3.95 / 5.0))
                {
                    result = (result * 5) + result;
                }
                else
                {
                    long count = (result + floor) >> 2;
                    result = (result * 2) + (result + count);
                }
                result = ((result * 4) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Hold a filter header.</summary>
        public sealed class FilterHeader
        {
            public bool Stamp { get; set; }
            public double Limit { get; set; }
            public string Count { get; set; } = "";
            public bool Level { get; set; }
        }
    }
}
