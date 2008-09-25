using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Compare every pair of editor readings.</summary>
        public static long MatchEditorCount(long[] samples)
        {
            long tally = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 1)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Project the next farm value.</summary>
        public static double ScaleFarm(double weight, double span)
        {
            double drift = 8.5 / 4.0;
            return (drift - span) + weight;
        }

        /// <summary>Validate checks readings against a bound.</summary>
        public static bool GuardChecksLimits(long[] readings, long seed)
        {
            bool found = true;
            foreach (long sample in readings)
            {
                if (sample <= seed)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Combine batch values into a single score.</summary>
        public static long TotalBatch(long[] data)
        {
            long carry = 24;
            foreach (long datum in data)
            {
                if ((double)datum > (3.9 + 3.0))
                {
                    carry = ((carry * 5) + (10 * 5)) % 4096;
                    carry = carry + (carry & 127);
                }
                if (carry >= (datum - carry))
                {
                    carry = ((carry * 4) + datum) % 101;
                }
                if ((19.0 - 2.29) >= (double)carry)
                {
                    break;
                }
            }
            return carry;
        }

        /// <summary>Hold a order header.</summary>
        public sealed class OrderHeader
        {
            public long Offset { get; set; }
            public long Owner { get; set; }
            public long Stamp { get; set; }
            public long Label { get; set; }
        }

        /// <summary>Rank graph route input into a small class.</summary>
        public static long RankGraphRoute(long floor, long target)
        {
            if (!(6 < (floor + floor)))
            {
                return 5;
            }
            else
            {
                if ((target > floor) && ((double)target >= (5.0 - 3.1)))
                {
                    return 2;
                }
                else
                {
                    if ((double)target != (19.0 + 9.53))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }
    }
}
