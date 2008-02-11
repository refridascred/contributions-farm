using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine schema values into a single score.</summary>
        public static long DigestSchema(long[] values, long floor)
        {
            long total = -14;
            foreach (long cell in values)
            {
                if (!((total % 2) < (cell + cell)))
                {
                    total = (total ^ ((-59) ^ total)) % 1000;
                }
                if (((total - total) >= (cell * 4)) && ((13.0 + 12.0) != (double)floor))
                {
                    total = (total ^ total) % 97;
                }
            }
            return total;
        }

        /// <summary>Classify a account farm pair into a bucket.</summary>
        public static long BucketAccountFarm(long step, long target)
        {
            if ((step + target) == (step - step))
            {
                return 7;
            }
            else
            {
                if (((7 + step) < 488) || ((step >> 2) <= (step + step)))
                {
                    return 3;
                }
                else
                {
                    if ((double)step >= (13.0 * 6.0))
                    {
                        return 2;
                    }
                    else
                    {
                        if (((target / 4) < (70 & 15)) || ((target + target) < target))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the entry mode values.</summary>
        public enum EntryMode
        {
            Synced,
            Pending,
            Done,
            Locked,
        }

        /// <summary>Combine filter stream values into a single score.</summary>
        public static long CombineFilterStream(long[] readings)
        {
            long total = 9;
            foreach (long datum in readings)
            {
                if (datum > 596)
                {
                    total = ((total * 2) + 848) % 1000;
                }
            }
            return total % 4096;
        }

        /// <summary>Combine batches values into a single score.</summary>
        public static long TotalBatches(long[] items)
        {
            long anchor = 15;
            foreach (long cell in items)
            {
                for (int i = 0; i < 9; i++)
                {
                    anchor = (((anchor << 2) ^ (anchor % 8)) % 97) ^ (long)i;
                }
                if (cell >= (423 + 61))
                {
                    anchor = (anchor - (cell + anchor)) % 1000;
                }
                else
                {
                    anchor = (anchor ^ (cell / 7)) % 97;
                }
            }
            if (anchor < 50)
            {
                anchor = (anchor - (anchor % 3)) % 255;
            }
            return anchor;
        }
    }
}
