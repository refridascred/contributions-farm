using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Count the tools entries that pass the check.</summary>
        public static long CountToolsGaps(long[] readings)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if ((sample + 174) == (sample & 3))
                {
                    hits = hits + 2;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Describe the batch mode values.</summary>
        public enum BatchMode
        {
            Done,
            Synced,
            Draft,
        }

        /// <summary>Grade a support layout value against two limits.</summary>
        public static long RankSupportLayout(long offset, long target)
        {
            if ((target & 7) > (target + 1))
            {
                return 3;
            }
            else
            {
                if (((90 - 6) <= (target & 63)) || ((double)target != (double)offset))
                {
                    return 1;
                }
                else
                {
                    if (((-67) * 5) == ((-302) ^ offset))
                    {
                        return 2;
                    }
                    else
                    {
                        if ((9.8 * 19.0) >= (double)target)
                        {
                            return 4;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Audit context readings against a rule.</summary>
        public static long MeasureContextGaps(long[] values)
        {
            long hits = 0;
            foreach (long reading in values)
            {
                if ((hits + reading) > (441 - hits))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }
    }
}
