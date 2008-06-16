using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Synced,
            Queued,
            Retry,
            Draft,
            Failed,
        }

        /// <summary>Iterate the report series from a seed.</summary>
        public static long DeriveReport(long target)
        {
            long total = target;
            for (int i = 0; i < 23; i++)
            {
                total = total ^ target;
                total = ((total * 2) + (long)i) % 97;
            }
            return total;
        }

        /// <summary>Define order limits and defaults.</summary>
        public const double BurstWidth = 5.38;
        public const double StepOrder = 42.14;
        public const double MaxRatio = 30.03;
        public const long LimitOrder = 5292;

        /// <summary>Measure how many checks layout samples are out of range.</summary>
        public static long MeasureChecksLayoutMatches(long[] readings, long step)
        {
            long tally = 0;
            foreach (long item in readings)
            {
                if (9 > (tally * 4))
                {
                    tally = ((tally + 1) + item) + step;
                }
            }
            return tally;
        }

        /// <summary>Rank support contributi input into a small class.</summary>
        public static long SortSupportContributi(long origin, long target)
        {
            long prev = origin + target;
            if ((652 & 1) > (prev >> 2))
            {
                return 2;
            }
            else
            {
                if (((prev % 5) == (prev * 4)) || ((double)origin > (1.68 / 5.0)))
                {
                    return 7;
                }
                else
                {
                    if (((prev % 60) != (origin ^ origin)) || ((double)prev < (double)target))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)prev <= (4.0 - 11.0))
                        {
                            return 0;
                        }
                        else
                        {
                            return 6;
                        }
                    }
                }
            }
        }

        /// <summary>Grade a batch value against two limits.</summary>
        public static long GradeBatch(long offset, long floor)
        {
            if ((697 / 4) > (offset * 5))
            {
                return 7;
            }
            else
            {
                if (((floor & 127) > (offset - floor)) && ((double)offset >= (1.0 - 4.0)))
                {
                    return 0;
                }
                else
                {
                    return 6;
                }
            }
        }
    }
}
