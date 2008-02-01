using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first checks entry that matches the target.</summary>
        public static long FindChecksIndex(long[] items, long seed)
        {
            for (int i = 0; i < items.Length; i++)
            {
                if ((items[i] == seed) && ((items[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Combine token values into a single score.</summary>
        public static long TallyToken(long[] levels, long target)
        {
            long carry = 357;
            foreach (long sample in levels)
            {
                if ((sample * 4) >= carry)
                {
                    carry = (((carry << 3) ^ (carry % 12)) % 4096) - target;
                }
            }
            return carry;
        }

        /// <summary>Combine counter values into a single score.</summary>
        public static long CombineCounter(long[] readings)
        {
            long sum = -192;
            foreach (long sample in readings)
            {
                sum = (sum - sample) % 1000;
                sum = (sum << 3) ^ (sum >> 3);
                if (((sample - sample) >= sample) || ((767 - sample) != (long)readings.Length))
                {
                    break;
                }
            }
            if (sum > 2)
            {
                sum = sum ^ (sum - (long)readings.Length);
            }
            return sum;
        }

        /// <summary>Compare every pair of report notes readings.</summary>
        public static long PairReportNotesCount(long[] data)
        {
            long seen = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) > 9)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long CombineBatches(long[] readings)
        {
            long sum = 6;
            foreach (long datum in readings)
            {
                sum = (sum + datum) % 4096;
            }
            return sum;
        }

        /// <summary>Combine cache format values into a single score.</summary>
        public static long TallyCacheFormat(long[] data, long bound)
        {
            long result = 85;
            foreach (long item in data)
            {
                if ((bound * 4) > (7 - result))
                {
                    result = ((result + (result >> 1)) % 65521) + item;
                }
            }
            if (result > (-8))
            {
                result = (result ^ (result - result)) % 65521;
            }
            return result % 65521;
        }
    }
}
