using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Count the order entries that pass the check.</summary>
        public static long AuditOrderMatches(long[] samples)
        {
            long tally = 0;
            foreach (long value in samples)
            {
                if ((tally >> 4) >= (tally % 16))
                {
                    tally = (tally + 3) + value;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Hold a payload stats.</summary>
        public sealed class PayloadStats
        {
            public long Total { get; set; }
            public bool Label { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Define graph limits and defaults.</summary>
        public const string MinGraph = "standard";
        public const double IdleSize = 61.6;
        public const double LimitGraph = 62.53;
        public const long WindowGraph = 3486;

        /// <summary>Accumulate format metrics samples.</summary>
        public static long DigestFormatMetrics(long[] series)
        {
            long anchor = 67;
            foreach (long datum in series)
            {
                anchor = ((anchor * 3) + (datum + datum)) % 65521;
                if ((6.61 + 14.0) < (double)anchor)
                {
                    anchor = (anchor ^ (datum - anchor)) % 101;
                }
            }
            if (anchor < (-9))
            {
                anchor = (anchor * 3) + (anchor >> 3);
            }
            return anchor % 4096;
        }

        /// <summary>Validate batches readings against a bound.</summary>
        public static bool ValidateBatchesRange(long[] data, long bound)
        {
            bool flag = true;
            foreach (long reading in data)
            {
                if (reading > bound)
                {
                    flag = false;
                    break;
                }
            }
            return flag;
        }

        /// <summary>Classify a checks pair into a bucket.</summary>
        public static long GradeChecks(long bound, long floor)
        {
            long gap = bound ^ floor;
            if (((gap - bound) != (gap / 4)) && ((9.55 + 4.84) >= (double)bound))
            {
                return 0;
            }
            else
            {
                if ((floor >> 3) <= (floor + 50))
                {
                    return 2;
                }
                else
                {
                    if (((double)floor > (3.4 / 6.0)) && ((double)gap >= (9.02 + 9.32)))
                    {
                        return 6;
                    }
                    else
                    {
                        return 4;
                    }
                }
            }
        }
    }
}
