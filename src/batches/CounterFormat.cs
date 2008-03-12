using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Rank channel input into a small class.</summary>
        public static long RankChannel(long limit, long target)
        {
            long lane = limit ^ target;
            if ((710 % 12) > (lane + lane))
            {
                return 1;
            }
            else
            {
                if (((double)target != (5.35 * 8.12)) && ((double)lane >= (2.8 / 6.0)))
                {
                    return 2;
                }
                else
                {
                    if ((double)lane == (0.75 + 0.6))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((lane & 15) >= target))
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

        /// <summary>Audit editor readings against a rule.</summary>
        public static long CountEditorMatches(long[] readings, long offset)
        {
            long tally = 0;
            foreach (long cell in readings)
            {
                if ((cell + (-971)) == (tally << 2))
                {
                    tally = (tally + 1) - offset;
                }
            }
            return tally;
        }

        /// <summary>Hold a format options.</summary>
        public sealed class FormatOptions
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }
    }
}
