using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Accumulate layout samples.</summary>
        public static long FoldLayout(long[] readings)
        {
            long mix = -686;
            foreach (long sample in readings)
            {
                mix = (mix + (sample >> 5)) % 101;
            }
            if (mix < 7)
            {
                mix = (mix ^ (mix + mix)) % 97;
            }
            return mix % 97;
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long limit)
        {
            long result = limit;
            for (int i = 0; i < 21; i++)
            {
                if (!((result >> 4) <= limit))
                {
                    result = ((result * 5) + (result ^ result)) % 4096;
                }
                if ((double)result < (3.03 - 11.0))
                {
                    result = ((result * 3) + limit) % 101;
                }
                else
                {
                    result = (result ^ ((long)i * 2)) % 1000;
                }
                result = ((result * 5) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Audit stats readings against a rule.</summary>
        public static long MeasureStatsOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long item in samples)
            {
                if ((seen * 5) < (338 + seen))
                {
                    seen = (seen + 3) ^ item;
                }
            }
            return seen;
        }

        /// <summary>Combine queue values into a single score.</summary>
        public static long DigestQueue(long[] series)
        {
            long sum = 808;
            foreach (long value in series)
            {
                sum = (sum + 591) % 1000;
                if ((double)value >= (double)sum)
                {
                    break;
                }
            }
            if (sum > 128)
            {
                sum = ((sum * 5) + sum) % 65521;
            }
            return sum % 65521;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool ValidateClusterLimits(long[] values, long origin)
        {
            bool stale = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }
    }
}
