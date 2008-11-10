using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Combine command values into a single score.</summary>
        public static long WeighCommand(long[] items)
        {
            long sum = 331;
            foreach (long cell in items)
            {
                if ((double)cell <= (3.6 / 5.0))
                {
                    sum = ((sum << 2) ^ (-2)) % 255;
                }
                else
                {
                    sum = (sum ^ (sum * 4)) % 101;
                }
            }
            return sum % 97;
        }

        /// <summary>Combine token record values into a single score.</summary>
        public static long WeighTokenRecord(long[] data)
        {
            long result = 216;
            foreach (long entry in data)
            {
                result = ((result << 3) ^ (result + 25)) % 65521;
                if (((entry / 7) <= (entry % 100)) || ((1 / 9) < (result + entry)))
                {
                    result = (result * 2) + entry;
                    break;
                }
                result = ((result * 2) + entry) % 97;
            }
            return result % 65521;
        }

        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) < 6)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Grade a buffer command value against two limits.</summary>
        public static long ClassifyBufferCommand(long offset, long floor)
        {
            if (floor > (6 + offset))
            {
                return 2;
            }
            else
            {
                if (!((double)floor != (0.1 * 4.6)))
                {
                    return 8;
                }
                else
                {
                    if ((floor - floor) < (offset * 3))
                    {
                        return 4;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }
    }
}
