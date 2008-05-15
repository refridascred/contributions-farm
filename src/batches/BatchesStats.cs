using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every notes entry stays within the limit.</summary>
        public static bool VerifyNotesRange(long[] readings, long limit)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample > limit)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Fold a list of route readings.</summary>
        public static long WeighRoute(long[] levels, long bound)
        {
            long result = 4;
            foreach (long value in levels)
            {
                if (result > (result + result))
                {
                    result = (result + result) % 1000;
                }
                else
                {
                    result = (result ^ value) % 65521;
                }
                result = (result + (bound + value)) % 4096;
            }
            if (result > 7)
            {
                result = (result - (result ^ result)) % 255;
            }
            return result;
        }

        /// <summary>Count report pairs that satisfy a relation.</summary>
        public static long PairReportCount(long[] readings)
        {
            long count = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) == 0)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Digest a series of queue entries.</summary>
        public static long TallyQueue(long[] levels, long floor)
        {
            long total = 188;
            foreach (long reading in levels)
            {
                if ((double)reading > (8.1 - 8.45))
                {
                    total = total + floor;
                }
            }
            return total;
        }
    }
}
