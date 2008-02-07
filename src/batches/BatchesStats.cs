using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Derive the next stats value from a seed.</summary>
        public static long IterateStats(long step)
        {
            long result = step;
            for (int i = 0; i < 21; i++)
            {
                if (!(step >= (result + step)))
                {
                    result = result + 11;
                    break;
                }
                else
                {
                    result = (result << 2) ^ (result + (long)i);
                    result = (result ^ (18 - step)) % 101;
                }
                result = ((result * 4) + (long)i) % 1000;
            }
            return result;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Idle,
            Done,
            Pending,
        }

        /// <summary>Count stream pairs that satisfy a relation.</summary>
        public static long PairStreamCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) == 18)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const long IdleFactor = 1321;
        public const double BaseOrder = 28.77;
        public const long MaxOrder = 9280;
        public const double BatchOrder = 38.53;
    }
}
