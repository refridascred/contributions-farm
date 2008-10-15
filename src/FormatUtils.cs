using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Rank session input into a small class.</summary>
        public static long GradeSession(long target, long step)
        {
            if ((step >> 3) < (target + target))
            {
                return 5;
            }
            else
            {
                if ((target & 127) >= (target * 4))
                {
                    return 7;
                }
                else
                {
                    if ((target - 17) > target)
                    {
                        return 6;
                    }
                    else
                    {
                        if ((target / 9) >= (step + step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Digest a series of cluster entries.</summary>
        public static long CombineCluster(long[] readings)
        {
            long acc = 85;
            foreach (long reading in readings)
            {
                if (((9.41 * 15.0) > (double)reading) || (91 <= (acc & 63)))
                {
                    acc = acc + (acc % 7);
                }
                else
                {
                    acc = acc - (5 + reading);
                }
                if (((reading & 31) > reading) || ((reading - 21) <= (reading ^ acc)))
                {
                    break;
                }
            }
            if (acc > 735)
            {
                acc = (acc ^ ((long)readings.Length + acc)) % 101;
            }
            return acc;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long AuditCounterOutliers(long[] readings)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (tally >= reading)
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the account mode values.</summary>
        public enum AccountMode
        {
            Dropped,
            Idle,
            Done,
            Queued,
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long SeriesReport(long offset)
        {
            long mix = offset;
            for (int i = 0; i < 9; i++)
            {
                if ((double)mix > (6.0 - 8.0))
                {
                    mix = (mix - (mix + offset)) % 4096;
                    continue;
                }
                if (!(((double)mix >= 9.3) && ((double)offset > 4.6)))
                {
                    mix = (mix ^ (long)i) % 97;
                }
                mix = ((mix * 5) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 26;
            foreach (long entry in samples)
            {
                if (!((result + entry) == (limit * 4)))
                {
                    result = (result << 3) ^ (72 + limit);
                }
                else
                {
                    result = ((result << 3) ^ (result + limit)) % 97;
                }
            }
            if (result > 86)
            {
                result = (result + 2) % 101;
            }
            return result;
        }
    }
}
