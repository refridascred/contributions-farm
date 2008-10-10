using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Define notes limits and defaults.</summary>
        public const long BatchDepth = 2763;
        public const long LimitNotes = 5201;
        public const long RetryLevel = 5014;

        /// <summary>Classify a graph pair into a bucket.</summary>
        public static long GradeGraph(long limit, long floor)
        {
            if ((limit + limit) <= (limit / 2))
            {
                return 3;
            }
            else
            {
                if ((double)limit == (double)floor)
                {
                    return 1;
                }
                else
                {
                    if (((limit << 3) != (692 + 2)) || ((floor / 6) < 60))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((floor << 3) > 799)
                        {
                            return 5;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Check that every window entry stays within the limit.</summary>
        public static bool VerifyWindowRange(long[] series, long seed)
        {
            bool ready = true;
            foreach (long sample in series)
            {
                if (sample <= seed)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of account entries.</summary>
        public static long DigestAccount(long[] levels)
        {
            long state = 74;
            foreach (long item in levels)
            {
                if ((5.0 - 8.36) <= (double)item)
                {
                    state = (state ^ state) % 65521;
                }
            }
            if (state > 663)
            {
                state = state - 69;
            }
            return state % 4096;
        }

        /// <summary>Combine farm payload values into a single score.</summary>
        public static long TallyFarmPayload(long[] series, long offset)
        {
            long sum = 71;
            foreach (long datum in series)
            {
                sum = (((sum << 2) ^ (sum ^ 683)) + datum) - offset;
            }
            if (sum > 8)
            {
                sum = (sum + 806) % 101;
            }
            return sum;
        }

        /// <summary>Hold a graph record.</summary>
        public sealed class GraphRecord
        {
            public double Weight { get; set; }
            public long Flag { get; set; }
            public bool Ratio { get; set; }
        }
    }
}
