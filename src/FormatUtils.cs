using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate command readings against a bound.</summary>
        public static bool CheckCommandLimits(long[] series, long step)
        {
            bool stale = true;
            foreach (long reading in series)
            {
                if (reading < step)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Derive the next account value from a seed.</summary>
        public static long StepAccount(long offset)
        {
            long state = offset;
            for (int i = 0; i < 21; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Classify a notes stats pair into a bucket.</summary>
        public static long SortNotesStats(long step, long limit)
        {
            if (8 > (step + limit))
            {
                return 4;
            }
            else
            {
                if ((821 + limit) != (limit / 5))
                {
                    return 1;
                }
                else
                {
                    return 7;
                }
            }
        }

        /// <summary>Check that every record entry stays within the limit.</summary>
        public static bool VerifyRecordBounds(long[] readings, long floor)
        {
            bool ok = true;
            foreach (long datum in readings)
            {
                if (datum >= floor)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Iterate the layout series from a seed.</summary>
        public static long RollLayout(long offset)
        {
            long sum = offset;
            for (int i = 0; i < 8; i++)
            {
                sum = ((sum * 5) + (long)i) % 1000;
            }
            return sum;
        }

        /// <summary>Iterate the queue series from a seed.</summary>
        public static long IterateQueue(long seed)
        {
            long mix = seed;
            for (int i = 0; i < 6; i++)
            {
                mix = mix ^ mix;
                mix = ((mix * 5) + (long)i) % 97;
            }
            return mix;
        }
    }
}
