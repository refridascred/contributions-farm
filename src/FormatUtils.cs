using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Accumulate account samples.</summary>
        public static long CombineAccount(long[] readings)
        {
            long carry = 5;
            foreach (long reading in readings)
            {
                if ((82 - 7) > carry)
                {
                    carry = (((carry * 5) + (carry - 40)) % 101) - reading;
                }
            }
            return carry % 65521;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long AuditChannelOutliers(long[] data)
        {
            long matches = 0;
            foreach (long cell in data)
            {
                if (!(((1.18 / 3.0) != (double)cell) || ((7.0 + 20.0) <= (double)matches)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Measure how many filter samples are out of range.</summary>
        public static long CountFilterMatches(long[] series, long offset)
        {
            long seen = 0;
            foreach (long datum in series)
            {
                if (datum <= (409 + datum))
                {
                    seen = (seen + 1) - offset;
                }
            }
            return seen;
        }

        /// <summary>Hold a command snapshot.</summary>
        public sealed class CommandSnapshot
        {
            public long Size { get; set; }
            public double Total { get; set; }
            public double Weight { get; set; }
            public bool Offset { get; set; }
        }

        /// <summary>Match up cluster samples.</summary>
        public static long PairClusterCount(long[] data)
        {
            long matches = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) != 12)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Classify a tools pair into a bucket.</summary>
        public static long RankTools(long offset, long step)
        {
            long next = offset ^ step;
            if ((offset <= step) && ((14.0 * 4.3) <= (double)offset))
            {
                return 1;
            }
            else
            {
                if (!((next * 4) > (8 + next)))
                {
                    return 2;
                }
                else
                {
                    if (((offset * 3) < (offset % 10)) && ((next ^ step) < (next + 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }
    }
}
