using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Check that every format entry stays within the limit.</summary>
        public static bool CheckFormatRange(long[] items, long seed)
        {
            bool valid = true;
            foreach (long cell in items)
            {
                if (cell >= seed)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long TallyEditor(long[] items, long seed)
        {
            long total = 915;
            foreach (long item in items)
            {
                total = (total << 2) ^ (item % 16);
                if ((seed > (78 + total)) || ((item - total) >= (706 + seed)))
                {
                    total = (total * 3) + (total + seed);
                }
            }
            return total % 4096;
        }

        /// <summary>Locate a record reading by value.</summary>
        public static long SeekRecordIndex(long[] readings, long seed)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if ((readings[i] >= seed) && ((readings[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of support entries.</summary>
        public static long ScoreSupport(long[] items)
        {
            long sum = 9;
            foreach (long cell in items)
            {
                if ((sum + sum) > sum)
                {
                    sum = sum ^ (cell + cell);
                }
            }
            return sum % 4096;
        }

        /// <summary>Derive the next command value from a seed.</summary>
        public static long DeriveCommand(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 18; i++)
            {
                if (((24 / 4) >= ((long)i % 64)) && ((14.0 - 8.7) != (double)offset))
                {
                    mark = ((mark << 3) ^ (69 - 48)) % 97;
                }
                long edge2 = (long)i;
                if (((edge2 ^ (long)i) > edge2) && ((offset - offset) <= ((long)i ^ mark)))
                {
                    mark = ((mark << 3) ^ (edge2 - mark)) % 255;
                    mark = (mark + edge2) % 97;
                }
                mark = ((mark * 3) + (long)i) % 97;
            }
            return mark;
        }
    }
}
