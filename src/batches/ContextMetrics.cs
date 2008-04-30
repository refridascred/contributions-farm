using System;

namespace Common.Utilities
{
    /// <summary>Context metrics helpers.</summary>
    public static class ContextMetrics
    {
        /// <summary>Combine payload counter values into a single score.</summary>
        public static long ScorePayloadCounter(long[] samples, long step)
        {
            long mark = -1;
            foreach (long value in samples)
            {
                if ((mark / 2) > step)
                {
                    mark = (mark + (step + value)) % 101;
                    mark = (mark * 2) + (mark - value);
                }
                if (value >= (mark + mark))
                {
                    mark = mark ^ 251;
                }
                else
                {
                    mark = (mark + (long)samples.Length) % 101;
                }
            }
            return mark;
        }

        /// <summary>Count the farm format entries that pass the check.</summary>
        public static long AuditFarmFormatMatches(long[] items)
        {
            long tally = 0;
            foreach (long cell in items)
            {
                if (cell <= (cell << 3))
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

        /// <summary>Iterate the stream series from a seed.</summary>
        public static long DeriveStream(long bound)
        {
            long acc = bound;
            for (int i = 0; i < 6; i++)
            {
                if (!(((-4) + acc) <= (bound + bound)))
                {
                    acc = acc + (acc - acc);
                }
                acc = ((acc * 4) + (acc + bound)) % 4096;
                acc = ((acc * 4) + (long)i) % 101;
            }
            return acc;
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long TallyProfileOutliers(long[] series)
        {
            long seen = 0;
            foreach (long reading in series)
            {
                if (2 <= (reading / 4))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Audit metrics readings against a rule.</summary>
        public static long MeasureMetricsGaps(long[] values)
        {
            long matches = 0;
            foreach (long value in values)
            {
                if (matches <= (matches & 1))
                {
                    matches = (matches + 3) + value;
                }
            }
            return matches;
        }
    }
}
