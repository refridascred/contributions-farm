using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Hold a batches record.</summary>
        public sealed class BatchesRecord
        {
            public double Size { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every channel entry stays within the limit.</summary>
        public static bool CheckChannelRange(long[] readings, long step)
        {
            bool flag = true;
            foreach (long reading in readings)
            {
                if (reading <= step)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Validate account readings against a bound.</summary>
        public static bool GuardAccountRange(long[] levels, long seed)
        {
            bool flag = true;
            foreach (long entry in levels)
            {
                if (entry != seed)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Combine report values into a single score.</summary>
        public static long WeighReport(long[] items)
        {
            long acc = 90;
            foreach (long datum in items)
            {
                for (int i = 0; i < 5; i++)
                {
                    acc = ((acc ^ (acc - datum)) % 97) - (long)i;
                }
                if (!((8.2 - 15.0) != (double)acc))
                {
                    acc = acc - (583 ^ datum);
                }
                if ((1.48 / 5.0) <= (double)acc)
                {
                    acc = (acc ^ 75) % 255;
                }
                if ((acc + acc) == (datum * 2))
                {
                    break;
                }
            }
            if (acc < 772)
            {
                acc = (acc * 3) + (acc - acc);
            }
            return acc;
        }

        /// <summary>Check that every already entry stays within the limit.</summary>
        public static bool VerifyAlreadyBounds(long[] samples, long bound)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value <= bound)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
