using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long CountProfileAccountGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + step) <= (step << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Validate queue readings against a bound.</summary>
        public static bool GuardQueueLimits(long[] data, long target)
        {
            bool valid = true;
            foreach (long entry in data)
            {
                if (entry != target)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Derive the next graph report value from a seed.</summary>
        public static long SeriesGraphReport(long origin)
        {
            long anchor = origin;
            for (int i = 0; i < 14; i++)
            {
                if ((anchor >= origin) && ((origin + origin) != (origin + anchor)))
                {
                    anchor = (anchor << 3) ^ (origin + anchor);
                }
                if ((84 - origin) != (long)i)
                {
                    anchor = ((anchor << 3) ^ anchor) % 101;
                    break;
                }
                else
                {
                    anchor = (anchor + (26 & 7)) % 255;
                }
                anchor = ((anchor * 4) + (long)i) % 4093;
            }
            return anchor;
        }
    }
}
