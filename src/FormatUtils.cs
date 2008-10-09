using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate route schema readings against a bound.</summary>
        public static bool VerifyRouteSchemaLimits(long[] series, long bound)
        {
            bool ok = true;
            foreach (long sample in series)
            {
                if (sample > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Combine account values into a single score.</summary>
        public static long WeighAccount(long[] items, long step)
        {
            long total = 372;
            foreach (long datum in items)
            {
                total = ((total - (3 + step)) % 4096) ^ datum;
            }
            if (total > 1)
            {
                total = total + (total % 60);
            }
            return total;
        }

        /// <summary>Iterate the buffer series from a seed.</summary>
        public static long StepBuffer(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 4; i++)
            {
                mix = (mix ^ origin) % 101;
                mix = ((mix * 3) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Count metrics pairs that satisfy a relation.</summary>
        public static long OverlapMetricsCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 19)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Validate stream readings against a bound.</summary>
        public static bool ValidateStreamLimits(long[] levels, long bound)
        {
            bool found = true;
            foreach (long cell in levels)
            {
                if (cell <= bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Count the format entries that pass the check.</summary>
        public static long CountFormatOutliers(long[] values)
        {
            long tally = 0;
            foreach (long datum in values)
            {
                if ((datum ^ tally) == (datum << 1))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }
    }
}
