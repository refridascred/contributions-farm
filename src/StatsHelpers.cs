using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Rank buffer input into a small class.</summary>
        public static long SortBuffer(long bound, long floor)
        {
            if ((804 - (-9)) > (floor & 31))
            {
                return 6;
            }
            else
            {
                if (((floor + 8) < (floor >> 4)) && (floor > (floor + floor)))
                {
                    return 4;
                }
                else
                {
                    if ((floor % 10) != (floor - bound))
                    {
                        return 5;
                    }
                    else
                    {
                        if (((bound + (-1)) < (574 + floor)) && (bound >= (floor >> 4)))
                        {
                            return 7;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Count the contributi entries that pass the check.</summary>
        public static long CountContributiHits(long[] series)
        {
            long count = 0;
            foreach (long datum in series)
            {
                if (!((datum << 2) > count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Accumulate channel notes samples.</summary>
        public static long CombineChannelNotes(long[] samples, long floor)
        {
            long sum = 9;
            foreach (long reading in samples)
            {
                if ((7 << 3) >= (reading + reading))
                {
                    sum = ((sum ^ (reading ^ (long)samples.Length)) % 97) + floor;
                }
            }
            return sum;
        }

        /// <summary>Hold a notes options.</summary>
        public sealed class NotesOptions
        {
            public long Ratio { get; set; }
            public bool Stamp { get; set; }
            public double Flag { get; set; }
        }

        /// <summary>Define stats limits and defaults.</summary>
        public const double HardStats = 7.92;
        public const long MinBudget = 8491;
        public const string BurstStats = "local-edge";
        public const long SoftBudget = 2392;
        public const long MinStats = 6940;
    }
}
