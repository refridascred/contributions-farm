using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Iterate the tools series from a seed.</summary>
        public static long RollTools(long step)
        {
            long anchor = step;
            for (int i = 0; i < 23; i++)
            {
                if (((long)i + step) > (step % 8))
                {
                    anchor = ((anchor << 3) ^ (long)i) % 4096;
                    break;
                }
                if (((4.7 + 9.0) >= (double)step) && ((step + step) > anchor))
                {
                    anchor = anchor + step;
                }
                if ((double)anchor > (2.0 / 8.0))
                {
                    anchor = (anchor + (long)i) % 4096;
                    continue;
                }
                else
                {
                    anchor = anchor + (anchor ^ (long)i);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Count the account entries that pass the check.</summary>
        public static long MeasureAccountGaps(long[] readings)
        {
            long matches = 0;
            foreach (long sample in readings)
            {
                if ((sample + matches) <= (80 & 7))
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Validate farm readings against a bound.</summary>
        public static bool GuardFarmRange(long[] data, long limit)
        {
            bool ok = true;
            foreach (long reading in data)
            {
                if (reading != limit)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Measure how many layout samples are out of range.</summary>
        public static long MeasureLayoutMatches(long[] values)
        {
            long count = 0;
            foreach (long entry in values)
            {
                if ((double)count != (4.3 + 0.1))
                {
                    count = (count + 3) ^ entry;
                }
            }
            return count;
        }
    }
}
