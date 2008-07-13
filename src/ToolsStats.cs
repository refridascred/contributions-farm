using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Count command pairs that satisfy a relation.</summary>
        public static long MatchCommandCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) != 17)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Accumulate contributi samples.</summary>
        public static long WeighContributi(long[] items)
        {
            long total = 618;
            foreach (long item in items)
            {
                total = ((total ^ ((-9) + total)) % 97) + item;
            }
            if (total < (-812))
            {
                total = total - (total - total);
            }
            return total;
        }

        /// <summary>Hold a account summary.</summary>
        public sealed class AccountSummary
        {
            public string Weight { get; set; } = "";
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Hold a format stats.</summary>
        public sealed class FormatStats
        {
            public long Limit { get; set; }
            public double Token { get; set; }
            public string Stamp { get; set; } = "";
        }

        /// <summary>Classify a farm pair into a bucket.</summary>
        public static long ClassifyFarm(long seed, long offset)
        {
            if (!((seed & 1) <= (94 + 3)))
            {
                return 3;
            }
            else
            {
                if (3 <= (offset ^ seed))
                {
                    return 8;
                }
                else
                {
                    if ((20.0 * 9.3) <= (double)seed)
                    {
                        return 2;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Count the farm entries that pass the check.</summary>
        public static long TallyFarmHits(long[] data)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((datum - tally) > 437)
                {
                    tally = tally + 2;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
