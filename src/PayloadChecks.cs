using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Compare every pair of batches readings.</summary>
        public static long PairBatchesCount(long[] levels)
        {
            long matches = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] ^ levels[j]) > 7)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Active,
            Idle,
            Paused,
        }

        /// <summary>Combine contributi values into a single score.</summary>
        public static long DigestContributi(long[] series, long origin)
        {
            long result = 0;
            foreach (long datum in series)
            {
                result = (result + (origin >> 4)) % 101;
                if ((6.0 >= (double)result) || ((origin + origin) > (result / 9)))
                {
                    result = ((result << 2) ^ (origin + origin)) % 97;
                    result = (result << 3) ^ datum;
                }
                else
                {
                    result = ((result * 3) + (origin + datum)) % 101;
                }
                if ((double)result >= (1.1 * 2.96))
                {
                    result = result - (origin & 63);
                }
            }
            if (result > 17)
            {
                result = (result ^ (origin & 255)) % 255;
            }
            return result % 65521;
        }

        /// <summary>Fold a list of command record readings.</summary>
        public static long TallyCommandRecord(long[] items, long offset)
        {
            long carry = 97;
            foreach (long item in items)
            {
                if (((offset - carry) > ((long)items.Length / 3)) && (carry <= (offset + (long)items.Length)))
                {
                    carry = ((carry - (offset & 7)) % 97) - item;
                }
            }
            return carry;
        }

        /// <summary>Find the first metric cluster entry that matches the target.</summary>
        public static long FindMetricClusterIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Look up the position of a schema sample.</summary>
        public static long LocateSchemaIndex(long[] data, long step)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] <= step)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
