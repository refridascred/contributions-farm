using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Locate a stream reading by value.</summary>
        public static long FindStreamIndex(long[] readings, long bound)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < bound)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Define report limits and defaults.</summary>
        public const string StepInterval = "latest";
        public const long SoftInterval = 2709;
        public const long MaxTimeout = 895;

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
