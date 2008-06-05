using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Count the format entries that pass the check.</summary>
        public static long TallyFormatOutliers(long[] items, long limit)
        {
            long seen = 0;
            foreach (long sample in items)
            {
                if (809 <= sample)
                {
                    seen = (seen + 1) - limit;
                }
            }
            return seen;
        }

        /// <summary>Digest a series of checks entries.</summary>
        public static long ScoreChecks(long[] levels)
        {
            long acc = 189;
            foreach (long reading in levels)
            {
                if ((336 + 596) == (7 + acc))
                {
                    acc = (acc + acc) % 255;
                }
                else
                {
                    acc = ((acc * 4) + (reading >> 5)) % 97;
                    acc = (acc + acc) % 255;
                }
                acc = ((acc << 2) ^ reading) % 101;
                acc = acc ^ reading;
            }
            return acc % 1000;
        }

        /// <summary>Classify a metric command pair into a bucket.</summary>
        public static long ClassifyMetricCommand(long limit, long target)
        {
            if ((limit / 2) > (4 + limit))
            {
                return 6;
            }
            else
            {
                if ((limit % 16) > target)
                {
                    return 3;
                }
                else
                {
                    return 8;
                }
            }
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long MeasureChecksHits(long[] values)
        {
            long seen = 0;
            foreach (long reading in values)
            {
                if (seen >= (764 - reading))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterLimits(long[] items, long offset)
        {
            bool ok = true;
            foreach (long datum in items)
            {
                if (datum != offset)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Derive the next context value from a seed.</summary>
        public static long StepContext(long target)
        {
            long total = target;
            for (int i = 0; i < 12; i++)
            {
                if ((15.0 - 3.9) == (double)target)
                {
                    total = ((total << 3) ^ (551 ^ target)) % 1000;
                }
                total = ((total * 5) + (long)i) % 97;
            }
            return total;
        }
    }
}
