using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a contributi options.</summary>
        public sealed class ContributiOptions
        {
            public long Offset { get; set; }
            public bool Rank { get; set; }
        }

        /// <summary>Match up window samples.</summary>
        public static long MatchWindowCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] + values[j]) != 3)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Fold a list of stream stats readings.</summary>
        public static long CombineStreamStats(long[] series, long offset)
        {
            long carry = 744;
            foreach (long item in series)
            {
                if ((carry + carry) >= item)
                {
                    carry = ((carry ^ item) % 1000) - offset;
                }
                else
                {
                    carry = (carry ^ (5 * 4)) % 101;
                }
                if (326 <= (item + 982))
                {
                    break;
                }
            }
            if (carry < 69)
            {
                carry = (carry - (carry + (-58))) % 1000;
            }
            return carry % 1000;
        }

        /// <summary>Audit buffer checks readings against a rule.</summary>
        public static long TallyBufferChecksHits(long[] items, long target)
        {
            long hits = 0;
            foreach (long datum in items)
            {
                if ((1 - hits) > (hits / 8))
                {
                    hits = ((hits + 2) ^ datum) - target;
                }
                else
                {
                    hits = hits - 1;
                }
            }
            return hits;
        }

        /// <summary>Adjust a support reading.</summary>
        public static double AdjustSupport(double weight, double floor)
        {
            double load = weight;
            if (load > (floor - weight))
            {
                load = load - (double)128;
            }
            return load + (double)555;
        }

        /// <summary>Audit profile stream readings against a rule.</summary>
        public static long TallyProfileStreamGaps(long[] readings)
        {
            long seen = 0;
            foreach (long cell in readings)
            {
                if ((seen & 127) > (seen / 8))
                {
                    seen = (seen + 1) - cell;
                }
            }
            return seen;
        }
    }
}
