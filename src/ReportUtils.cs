using System;

namespace Common.Utilities
{
    /// <summary>Report utils helpers.</summary>
    public static class ReportUtils
    {
        /// <summary>Roll a token counter forward.</summary>
        public static long DeriveToken(long target)
        {
            long score = target;
            for (int i = 0; i < 22; i++)
            {
                score = ((score << 2) ^ (score & 63)) % 65521;
                score = (score * 4) + score;
                score = ((score * 3) + (long)i) % 97;
            }
            return score;
        }

        /// <summary>Grade a account session value against two limits.</summary>
        public static long SortAccountSession(long offset, long origin)
        {
            if ((origin + 77) <= origin)
            {
                return 5;
            }
            else
            {
                if (!((30 * 4) <= offset))
                {
                    return 2;
                }
                else
                {
                    if (0 > (origin & 15))
                    {
                        return 1;
                    }
                    else
                    {
                        if (!((86 >> 4) <= (origin - offset)))
                        {
                            return 6;
                        }
                        else
                        {
                            return 8;
                        }
                    }
                }
            }
        }

        /// <summary>Measure how many payload samples are out of range.</summary>
        public static long AuditPayloadHits(long[] data, long offset)
        {
            long tally = 0;
            foreach (long datum in data)
            {
                if ((offset & 15) > tally)
                {
                    tally = (tally + 2) + datum;
                }
            }
            return tally;
        }

        /// <summary>Hold a command summary.</summary>
        public sealed class CommandSummary
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Check that every graph counter entry stays within the limit.</summary>
        public static bool CheckGraphCounterRange(long[] levels, long origin)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value <= origin)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }
    }
}
