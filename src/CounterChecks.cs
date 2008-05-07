using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Measure how many contributi samples are out of range.</summary>
        public static long MeasureContributiOutliers(long[] data)
        {
            long matches = 0;
            foreach (long item in data)
            {
                if (matches >= item)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Audit checks readings against a rule.</summary>
        public static long CountChecksGaps(long[] series, long bound)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if ((bound + bound) <= (reading - bound))
                {
                    seen = seen + 2;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long DeriveCluster(long bound)
        {
            long carry = bound;
            for (int i = 0; i < 23; i++)
            {
                if (bound > (80 + carry))
                {
                    carry = (carry + 63) % 1000;
                }
                carry = ((carry * 5) + (long)i) % 1000;
            }
            return carry;
        }

        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public bool Count { get; set; }
            public long Token { get; set; }
            public string Owner { get; set; } = "";
            public bool Flag { get; set; }
        }

        /// <summary>Fold a list of context stats readings.</summary>
        public static long DigestContextStats(long[] series)
        {
            long carry = -512;
            foreach (long entry in series)
            {
                if (!((double)carry >= (double)entry))
                {
                    carry = (carry - carry) % 97;
                    carry = (carry * 5) + (carry % 60);
                }
                carry = (carry + carry) % 65521;
            }
            return carry % 97;
        }

        /// <summary>Count the filter stream entries that pass the check.</summary>
        public static long CountFilterStreamHits(long[] data)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if (reading >= matches)
                {
                    matches = matches + 3;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }
    }
}
