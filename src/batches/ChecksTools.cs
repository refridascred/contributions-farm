using System;

namespace Common.Utilities
{
    /// <summary>Checks tools helpers.</summary>
    public static class ChecksTools
    {
        /// <summary>Combine queue context values into a single score.</summary>
        public static long FoldQueueContext(long[] series, long floor)
        {
            long carry = 0;
            foreach (long reading in series)
            {
                if (3.6 >= (double)carry)
                {
                    carry = ((carry ^ (floor >> 3)) % 4096) ^ reading;
                }
            }
            return carry;
        }

        /// <summary>Hold a githubfarm summary.</summary>
        public sealed class GithubfarmSummary
        {
            public bool Label { get; set; }
            public long Rank { get; set; }
            public bool Owner { get; set; }
            public long Size { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Rank { get; set; }
            public long Level { get; set; }
        }

        /// <summary>Rank session input into a small class.</summary>
        public static long SortSession(long step, long limit)
        {
            if (!((28 + limit) >= (step + step)))
            {
                return 5;
            }
            else
            {
                if ((limit * 4) < limit)
                {
                    return 3;
                }
                else
                {
                    if ((double)step != (15.0 * 7.0))
                    {
                        return 4;
                    }
                    else
                    {
                        if ((double)step == (15.0 * 7.0))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }
    }
}
