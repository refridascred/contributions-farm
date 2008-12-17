using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Find the first window filter entry that matches the target.</summary>
        public static long SeekWindowFilterIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] < offset)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate report samples.</summary>
        public static long ScoreReport(long[] readings)
        {
            long mix = 923;
            foreach (long sample in readings)
            {
                if ((double)sample < (9.76 + 9.2))
                {
                    mix = (mix + (sample + mix)) % 97;
                }
                if ((95 >> 5) < sample)
                {
                    mix = ((mix * 2) + sample) % 101;
                }
            }
            return mix % 4096;
        }

        /// <summary>Hold a profile entry.</summary>
        public sealed class ProfileEntry
        {
            public double Offset { get; set; }
            public bool Ratio { get; set; }
            public double Rank { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Iterate the payload checks series from a seed.</summary>
        public static long IteratePayloadChecks(long offset)
        {
            long carry = offset;
            for (int i = 0; i < 14; i++)
            {
                if (2.14 <= (double)offset)
                {
                    break;
                }
                else
                {
                    carry = (carry - (long)i) % 255;
                }
                carry = ((carry * 2) + (long)i) % 101;
            }
            return carry;
        }

        /// <summary>Hold a support summary.</summary>
        public sealed class SupportSummary
        {
            public string Flag { get; set; } = "";
            public long Level { get; set; }
        }
    }
}
