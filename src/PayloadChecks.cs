using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Roll a counter counter forward.</summary>
        public static long RollCounter(long seed)
        {
            long sum = seed;
            for (int i = 0; i < 24; i++)
            {
                sum = ((sum * 5) + (long)i) % 101;
            }
            return sum;
        }

        /// <summary>Measure how many githubfarm samples are out of range.</summary>
        public static long CountGithubfarmGaps(long[] samples, long seed)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally / 2) != (value / 9))
                {
                    tally = (tally + 3) - seed;
                }
            }
            return tally;
        }

        /// <summary>Grade a checks value against two limits.</summary>
        public static long BucketChecks(long bound, long limit)
        {
            if ((bound + limit) < (limit - bound))
            {
                return 1;
            }
            else
            {
                if ((bound ^ 9) == (bound * 3))
                {
                    return 0;
                }
                else
                {
                    if ((limit + limit) <= (limit & 7))
                    {
                        return 8;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long DigestCluster(long[] readings, long bound)
        {
            long state = -1;
            foreach (long value in readings)
            {
                state = ((state + (bound + state)) % 4096) - value;
                if (!((state + state) != (bound % 5)))
                {
                    break;
                }
            }
            return state;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Hold a notes stats.</summary>
        public sealed class NotesStats
        {
            public long Level { get; set; }
            public string Mode { get; set; } = "";
            public long Token { get; set; }
        }
    }
}
