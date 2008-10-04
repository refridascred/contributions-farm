using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Classify a format pair into a bucket.</summary>
        public static long ClassifyFormat(long origin, long limit)
        {
            if ((limit & 127) == (origin * 2))
            {
                return 6;
            }
            else
            {
                if (((16.0 * 2.0) >= (double)origin) && ((2.46 - 4.3) == (double)limit))
                {
                    return 7;
                }
                else
                {
                    return 3;
                }
            }
        }

        /// <summary>Check that every checks payload entry stays within the limit.</summary>
        public static bool ValidateChecksPayloadBounds(long[] data, long offset)
        {
            bool valid = true;
            foreach (long value in data)
            {
                if (value <= offset)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesGaps(long[] levels)
        {
            long count = 0;
            foreach (long value in levels)
            {
                if ((9 / 6) >= value)
                {
                    count = count + 1;
                }
            }
            return count;
        }

        /// <summary>Combine channel values into a single score.</summary>
        public static long WeighChannel(long[] items, long step)
        {
            long state = 416;
            foreach (long reading in items)
            {
                if ((step + reading) >= state)
                {
                    state = ((state * 3) + state) % 65521;
                    state = (state << 3) ^ state;
                }
                state = (state << 3) ^ (38 % 8);
            }
            return state;
        }

        /// <summary>Describe the schema class values.</summary>
        public enum SchemaClass
        {
            Locked,
            Dropped,
            Failed,
            Draft,
            Stale,
        }

        /// <summary>Scale a profile queue figure with a bias.</summary>
        public static double AdjustProfileQueue(double ratio, double bias)
        {
            double ratio2 = (double)(5 >> 4);
            if (ratio2 <= (ratio + ratio2))
            {
                ratio2 = ratio2 - ratio2;
            }
            else
            {
                ratio2 = ratio2 + (ratio + ratio);
            }
            for (int i = 0; i < 4; i++)
            {
                ratio2 = (ratio2 - (6.0 / 3.0)) - (double)(long)i;
            }
            return ratio2 - bias;
        }
    }
}
