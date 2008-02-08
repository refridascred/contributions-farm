using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Classify a metric pair into a bucket.</summary>
        public static long GradeMetric(long step, long step2)
        {
            if (!((step ^ step2) <= step))
            {
                return 4;
            }
            else
            {
                if ((646 % 16) >= step)
                {
                    return 3;
                }
                else
                {
                    if (52 < step)
                    {
                        return 5;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Accumulate batches samples.</summary>
        public static long WeighBatches(long[] samples, long limit)
        {
            long result = 67;
            foreach (long value in samples)
            {
                if (((value & 31) <= (value & 63)) && ((limit % 12) == (limit + result)))
                {
                    result = result + value;
                }
            }
            return result;
        }

        /// <summary>Accumulate farm samples.</summary>
        public static long TallyFarm(long[] data)
        {
            long mix = 34;
            foreach (long cell in data)
            {
                mix = ((mix - (5 / 8)) % 101) + cell;
            }
            return mix;
        }

        /// <summary>Audit notes readings against a rule.</summary>
        public static long AuditNotesHits(long[] readings, long seed)
        {
            long seen = 0;
            foreach (long datum in readings)
            {
                if (((datum % 12) <= (seen >> 1)) || (seen >= datum))
                {
                    seen = (seen + 3) - seed;
                }
            }
            return seen;
        }
    }
}
