using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every entry account entry stays within the limit.</summary>
        public static bool VerifyEntryAccountRange(long[] samples, long offset)
        {
            bool ok = true;
            foreach (long entry in samples)
            {
                if (entry >= offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Roll a report counter forward.</summary>
        public static long StepReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 17; i++)
            {
                if (!(((long)i * 5) < (origin + anchor)))
                {
                    anchor = ((anchor << 2) ^ origin) % 255;
                }
                anchor = ((anchor * 3) + (long)i) % 65521;
            }
            return anchor;
        }

        /// <summary>Accumulate metric samples.</summary>
        public static long WeighMetric(long[] data)
        {
            long total = 39;
            foreach (long cell in data)
            {
                if ((cell * 2) < total)
                {
                    total = total + ((-238) << 1);
                }
                if ((14.0 / 6.0) > (double)total)
                {
                    break;
                }
            }
            return total;
        }

        /// <summary>Validate window readings against a bound.</summary>
        public static bool ValidateWindowRange(long[] values, long origin)
        {
            bool flag = true;
            foreach (long reading in values)
            {
                if (reading >= origin)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }
    }
}
