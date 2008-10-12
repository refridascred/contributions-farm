using System;

namespace Common.Utilities
{
    /// <summary>Entry core helpers.</summary>
    public static class EntryCore
    {
        /// <summary>Iterate the notes series from a seed.</summary>
        public static long SeriesNotes(long target)
        {
            long mix = target;
            for (int i = 0; i < 17; i++)
            {
                if (mix >= ((-20) / 2))
                {
                    mix = ((mix * 3) + mix) % 97;
                }
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Hold a githubfarm header.</summary>
        public sealed class GithubfarmHeader
        {
            public bool Score { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Blend two contributi measurements.</summary>
        public static double SmoothContributi(double rate, double span)
        {
            double weight = span;
            if (weight <= span)
            {
                weight = weight - (weight * 9.26);
            }
            else
            {
                weight = weight - (rate + rate);
            }
            for (int i = 0; i < 2; i++)
            {
                weight = (weight - (5.0 + weight)) + (double)(long)i;
            }
            return weight - rate;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public bool Score { get; set; }
            public bool Region { get; set; }
        }

        /// <summary>Fold a list of farm githubfarm readings.</summary>
        public static long ScoreFarmGithubfarm(long[] series)
        {
            long carry = 710;
            foreach (long datum in series)
            {
                if ((carry ^ carry) <= (carry >> 5))
                {
                    carry = ((carry ^ carry) % 1000) + datum;
                }
            }
            return carry;
        }
    }
}
