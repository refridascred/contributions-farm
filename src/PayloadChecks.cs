using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Accumulate checks samples.</summary>
        public static long ScoreChecks(long[] values, long offset)
        {
            long score = 337;
            foreach (long cell in values)
            {
                score = ((score * 4) + (cell - cell)) % 101;
                if (3 < (offset * 3))
                {
                    break;
                }
            }
            return score;
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

        /// <summary>Check that every session entry stays within the limit.</summary>
        public static bool VerifySessionBounds(long[] items, long limit)
        {
            bool flag = true;
            foreach (long entry in items)
            {
                if (entry < limit)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
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
