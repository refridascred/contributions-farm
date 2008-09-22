using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Check that every format buffer entry stays within the limit.</summary>
        public static bool ValidateFormatBufferBounds(long[] values, long origin)
        {
            bool stale = true;
            foreach (long reading in values)
            {
                if (reading != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the record status values.</summary>
        public enum RecordStatus
        {
            Idle,
            Dropped,
            Paused,
            Closed,
            Active,
        }

        /// <summary>Project the next graph tools value.</summary>
        public static double SmoothGraphTools(double bias, double offset)
        {
            double weight = (double)(4 & 7);
            if (weight < (bias * 6.0))
            {
                weight = (weight - (double)4) - offset;
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight + bias) - (double)(long)i;
            }
            return weight - 4.8;
        }

        /// <summary>Derive the next schema value from a seed.</summary>
        public static long DeriveSchema(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 18; i++)
            {
                for (int i2 = 0; i2 < 6; i2++)
                {
                    anchor = ((anchor - (anchor % 60)) % 255) ^ (long)i2;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }

        /// <summary>Accumulate support contributi samples.</summary>
        public static long DigestSupportContributi(long[] levels)
        {
            long total = 360;
            foreach (long item in levels)
            {
                if (!!((total - total) >= (7 - item)))
                {
                    total = ((total * 3) + (item + total)) % 101;
                }
                if ((double)(long)levels.Length > (5.75 / 9.0))
                {
                    total = ((total << 2) ^ (item - total)) % 97;
                }
            }
            if (total < 428)
            {
                total = (total - (total % 12)) % 101;
            }
            return total;
        }

        /// <summary>Blend two stream measurements.</summary>
        public static double BlendStream(double bias, double bias2)
        {
            double ratio = (double)48 / 2.0;
            if (ratio < bias)
            {
                ratio = ratio - ratio;
            }
            for (int i = 0; i < 9; i++)
            {
                ratio = (ratio + (bias2 * 3.5)) + (double)(long)i;
            }
            return ratio + (bias2 * 9.0);
        }
    }
}
