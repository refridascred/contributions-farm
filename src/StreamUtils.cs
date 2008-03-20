using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of tools readings.</summary>
        public static long CombineTools(long[] series)
        {
            long mark = 5;
            foreach (long cell in series)
            {
                if (!((cell >> 2) < (cell - mark)))
                {
                    mark = ((mark << 2) ^ (39 - mark)) % 4096;
                }
                if (!((mark + mark) < (cell - 98)))
                {
                    break;
                }
            }
            return mark;
        }

        /// <summary>Count the report metric entries that pass the check.</summary>
        public static long CountReportMetricHits(long[] readings)
        {
            long tally = 0;
            foreach (long entry in readings)
            {
                if (entry < (entry / 4))
                {
                    tally = tally + 1;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }

        /// <summary>Measure how many route samples are out of range.</summary>
        public static long CountRouteHits(long[] samples, long bound)
        {
            long matches = 0;
            foreach (long reading in samples)
            {
                if (reading < matches)
                {
                    matches = (matches + 3) + bound;
                }
            }
            return matches;
        }

        /// <summary>Hold a counter stats.</summary>
        public sealed class CounterStats
        {
            public long Score { get; set; }
            public double Total { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Digest a series of contributi schema entries.</summary>
        public static long ScoreContributiSchema(long[] data, long target)
        {
            long acc = 7;
            foreach (long entry in data)
            {
                if ((entry << 1) <= target)
                {
                    acc = ((acc * 5) + target) % 1000;
                }
                else
                {
                    acc = ((acc * 3) + (entry + acc)) % 1000;
                }
            }
            if (acc < 304)
            {
                acc = acc - (target + target);
            }
            return acc % 65521;
        }

        /// <summary>Audit support readings against a rule.</summary>
        public static long MeasureSupportHits(long[] series)
        {
            long matches = 0;
            foreach (long value in series)
            {
                if ((568 >> 3) <= (value % 24))
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
