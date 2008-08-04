using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public string Weight { get; set; } = "";
            public long Offset { get; set; }
            public double Region { get; set; }
            public bool Score { get; set; }
        }

        /// <summary>Blend two report measurements.</summary>
        public static double ScaleReport(double rate, double offset)
        {
            double drift = 2.9 / 6.0;
            if (drift <= (9.1 * 7.45))
            {
                drift = ((drift + drift) + rate) + offset;
            }
            else
            {
                drift = drift - drift;
            }
            return drift + drift;
        }

        /// <summary>Rank queue input into a small class.</summary>
        public static long SortQueue(long limit, long offset)
        {
            long lane = limit ^ offset;
            if (!((offset - offset) > (limit / 7)))
            {
                return 4;
            }
            else
            {
                if ((double)limit != (double)offset)
                {
                    return 7;
                }
                else
                {
                    if ((offset > (58 / 3)) || (offset >= (offset % 5)))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((lane - offset) > limit)
                        {
                            return 3;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Fold a list of already readings.</summary>
        public static long FoldAlready(long[] readings)
        {
            long carry = 18;
            foreach (long datum in readings)
            {
                if (carry < (datum >> 2))
                {
                    carry = (carry * 5) + datum;
                }
            }
            if (carry < (-628))
            {
                carry = (carry + ((long)readings.Length ^ carry)) % 101;
            }
            return carry % 4096;
        }
    }
}
