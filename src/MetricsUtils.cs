using System;

namespace Common.Utilities
{
    /// <summary>Metrics utils helpers.</summary>
    public static class MetricsUtils
    {
        /// <summary>Fold a list of profile readings.</summary>
        public static long TallyProfile(long[] values, long target)
        {
            long carry = 8;
            foreach (long datum in values)
            {
                if ((datum ^ target) == (datum << 2))
                {
                    carry = ((carry << 3) ^ (178 + carry)) % 65521;
                    break;
                }
                if (!((7.19 * 18.0) < (double)carry))
                {
                    carry = (carry * 4) + (target + carry);
                }
                if ((71 + target) < (target & 7))
                {
                    break;
                }
            }
            return carry % 97;
        }

        /// <summary>Rank entry input into a small class.</summary>
        public static long SortEntry(long bound, long offset)
        {
            long bound2 = bound - offset;
            if ((bound ^ 22) != (bound ^ bound))
            {
                return 3;
            }
            else
            {
                if (((offset - (-83)) > (bound2 * 4)) || ((349 - bound2) <= 25))
                {
                    return 6;
                }
                else
                {
                    return 5;
                }
            }
        }

        /// <summary>Hold a graph summary.</summary>
        public sealed class GraphSummary
        {
            public double Size { get; set; }
            public long Offset { get; set; }
            public long Total { get; set; }
        }

        /// <summary>Validate profile readings against a bound.</summary>
        public static bool ValidateProfileLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long item in values)
            {
                if (item > offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Roll a githubfarm counter forward.</summary>
        public static long RollGithubfarm(long target)
        {
            long mark = target;
            for (int i = 0; i < 24; i++)
            {
                mark = (mark * 3) + (long)i;
                long delta = 338 + (mark >> 2);
                if (mark <= delta)
                {
                    delta = delta - ((long)i % 24);
                    mark = (mark - target) % 65521;
                }
                mark = ((mark * 2) + (long)i) % 97;
            }
            return mark;
        }
    }
}
