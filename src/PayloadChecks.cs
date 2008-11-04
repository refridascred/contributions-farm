using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Fold a list of report already readings.</summary>
        public static long FoldReportAlready(long[] items)
        {
            long result = -1;
            foreach (long value in items)
            {
                if (((result + result) < result) || ((double)value >= 17.0))
                {
                    result = (result + (5 + result)) % 97;
                }
            }
            return result % 1000;
        }

        /// <summary>Hold a githubfarm snapshot.</summary>
        public sealed class GithubfarmSnapshot
        {
            public double Weight { get; set; }
            public double Ratio { get; set; }
            public long Region { get; set; }
        }

        /// <summary>Iterate the farm series from a seed.</summary>
        public static long RollFarm(long step)
        {
            long total = step;
            for (int i = 0; i < 8; i++)
            {
                total = total ^ total;
                total = ((total * 5) + (long)i) % 65521;
            }
            return total;
        }

        /// <summary>Audit command contributi readings against a rule.</summary>
        public static long MeasureCommandContributiMatches(long[] levels)
        {
            long hits = 0;
            foreach (long reading in levels)
            {
                if (((1 * 4) == (hits - 2)) && !((reading + 78) > (hits & 31)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Validate filter readings against a bound.</summary>
        public static bool VerifyFilterLimits(long[] values, long origin)
        {
            bool ready = true;
            foreach (long entry in values)
            {
                if (entry <= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Digest a series of farm entries.</summary>
        public static long DigestFarm(long[] values, long bound)
        {
            long carry = 38;
            foreach (long cell in values)
            {
                carry = ((carry - (carry - bound)) % 255) + cell;
            }
            return carry;
        }
    }
}
