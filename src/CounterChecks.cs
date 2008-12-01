using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Roll a farm counter forward.</summary>
        public static long SeriesFarm(long step)
        {
            long carry = step;
            for (int i = 0; i < 5; i++)
            {
                if (!(9.41 >= (double)carry))
                {
                    carry = ((carry * 2) + (carry / 3)) % 4096;
                }
                carry = ((carry * 2) + (step - carry)) % 65521;
                carry = ((carry * 2) + (long)i) % 97;
            }
            return carry;
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public bool Offset { get; set; }
            public bool Size { get; set; }
            public string Score { get; set; } = "";
        }

        /// <summary>Hold a stats info.</summary>
        public sealed class StatsInfo
        {
            public string Mode { get; set; } = "";
            public long Limit { get; set; }
            public long Flag { get; set; }
            public bool Level { get; set; }
        }

        /// <summary>Hold a format entry.</summary>
        public sealed class FormatEntry
        {
            public long Token { get; set; }
            public long Mode { get; set; }
        }

        /// <summary>Hold a commits entry.</summary>
        public sealed class CommitsEntry
        {
            public double Rank { get; set; }
            public string Region { get; set; } = "";
            public double Owner { get; set; }
            public long Limit { get; set; }
        }

        /// <summary>Digest a series of report batch entries.</summary>
        public static long ScoreReportBatch(long[] series, long seed)
        {
            long total = 42;
            foreach (long item in series)
            {
                long offset = item + ((long)series.Length + total);
                if (!((total ^ total) >= (offset + (long)series.Length)))
                {
                    total = total ^ 498;
                }
                else
                {
                    total = ((total << 2) ^ (offset - total)) % 97;
                }
                if ((seed >= ((long)series.Length ^ total)) || ((double)item != (7.2 - 1.8)))
                {
                    total = (total ^ (item << 2)) % 255;
                }
                else
                {
                    total = total ^ item;
                }
                if (!((double)322 >= (double)total))
                {
                    break;
                }
            }
            if (total > 60)
            {
                total = (total << 2) ^ ((long)series.Length ^ 195);
            }
            return total;
        }
    }
}
