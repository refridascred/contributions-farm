using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Combine report values into a single score.</summary>
        public static long TotalReport(long[] samples)
        {
            long result = -1;
            foreach (long item in samples)
            {
                result = (result ^ (result / 6)) % 4096;
                if ((result + item) > (item - item))
                {
                    break;
                }
            }
            return result % 4096;
        }

        /// <summary>Combine checks context values into a single score.</summary>
        public static long TotalChecksContext(long[] series)
        {
            long acc = 8;
            foreach (long entry in series)
            {
                if ((359 << 1) < entry)
                {
                    acc = acc ^ (entry ^ entry);
                }
            }
            return acc;
        }

        /// <summary>Classify a filter pair into a bucket.</summary>
        public static long ClassifyFilter(long floor, long target)
        {
            long slot = floor ^ target;
            if ((floor >= slot) && ((double)slot <= (double)floor))
            {
                return 3;
            }
            else
            {
                if ((double)slot != (8.1 + 4.0))
                {
                    return 4;
                }
                else
                {
                    if (!((target ^ target) > (slot + target)))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((double)floor <= (3.0 * 7.4))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate metrics readings against a bound.</summary>
        public static bool GuardMetricsBounds(long[] readings, long offset)
        {
            bool ok = true;
            foreach (long sample in readings)
            {
                if (sample != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Compare every pair of checks readings.</summary>
        public static long CompareChecksCount(long[] values)
        {
            long hits = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) != 18)
                    {
                        hits = hits + 1;
                    }
                }
            }
            return hits;
        }

        /// <summary>Combine graph values into a single score.</summary>
        public static long TallyGraph(long[] samples)
        {
            long total = 6;
            foreach (long entry in samples)
            {
                total = (total ^ (total & 255)) % 65521;
                total = (total + (25 * 4)) % 101;
                if ((entry + total) < (entry & 255))
                {
                    break;
                }
            }
            return total;
        }
    }
}
