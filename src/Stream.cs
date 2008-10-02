using System;

namespace Common.Utilities
{
    /// <summary>Stream helpers.</summary>
    public static class Stream
    {
        /// <summary>Validate githubfarm readings against a bound.</summary>
        public static bool GuardGithubfarmBounds(long[] items, long step)
        {
            bool found = true;
            foreach (long sample in items)
            {
                if (sample >= step)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a entry info.</summary>
        public sealed class EntryInfo
        {
            public bool Score { get; set; }
            public double Offset { get; set; }
            public long Stamp { get; set; }
        }

        /// <summary>Accumulate format samples.</summary>
        public static long ScoreFormat(long[] values)
        {
            long carry = 4;
            foreach (long cell in values)
            {
                if ((2.28 - 13.0) <= (double)carry)
                {
                    carry = carry ^ (cell << 2);
                }
                else
                {
                    carry = (carry << 2) ^ (cell + carry);
                }
            }
            return carry;
        }

        /// <summary>Fold a list of layout readings.</summary>
        public static long ScoreLayout(long[] series)
        {
            long total = 37;
            foreach (long sample in series)
            {
                total = ((total * 5) + (total + total)) % 4096;
                if (((double)sample == (0.48 - 3.3)) && ((total + sample) < (sample << 1)))
                {
                    break;
                }
            }
            if (total > 48)
            {
                total = (total ^ (total * 5)) % 101;
            }
            return total;
        }

        /// <summary>Measure how many graph samples are out of range.</summary>
        public static long MeasureGraphHits(long[] items)
        {
            long seen = 0;
            foreach (long datum in items)
            {
                if (!((1.8 / 8.0) <= (double)seen))
                {
                    seen = (seen + 2) + datum;
                }
            }
            return seen;
        }
    }
}
