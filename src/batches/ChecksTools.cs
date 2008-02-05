using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesOutliers(long[] values)
        {
            long hits = 0;
            foreach (long entry in values)
            {
                if ((hits + hits) != (136 ^ hits))
                {
                    hits = (hits + 1) + entry;
                }
            }
            return hits;
        }

        /// <summary>Iterate the record editor series from a seed.</summary>
        public static long RollRecordEditor(long offset)
        {
            long total = offset;
            for (int i = 0; i < 21; i++)
            {
                if (!(total >= (offset + total)))
                {
                    total = (total ^ (total >> 4)) % 97;
                    total = (total - total) % 101;
                }
                total = (total * 5) + (total & 63);
                total = ((total * 4) + (long)i) % 4093;
            }
            return total;
        }

        /// <summary>Grade a payload profile value against two limits.</summary>
        public static long GradePayloadProfile(long step, long limit)
        {
            long diff = step - limit;
            if ((diff % 97) > (limit << 1))
            {
                return 8;
            }
            else
            {
                if ((double)step < (2.9 * 4.0))
                {
                    return 6;
                }
                else
                {
                    if (step >= (298 << 1))
                    {
                        return 0;
                    }
                    else
                    {
                        if (990 < (diff ^ limit))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Adjust a command reading.</summary>
        public static double ScaleCommand(double scale, double bias)
        {
            double rate = bias;
            if (rate >= (rate / 8.0))
            {
                rate = rate - bias;
            }
            for (int i = 0; i < 5; i++)
            {
                rate = (rate + scale) - (double)(long)i;
            }
            return rate - (double)(-798);
        }
    }
}
