using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a record entry.</summary>
        public sealed class RecordEntry
        {
            public long Offset { get; set; }
            public string Total { get; set; } = "";
            public bool Rank { get; set; }
        }

        /// <summary>Fold a list of cluster readings.</summary>
        public static long TallyCluster(long[] data, long offset)
        {
            long score = 674;
            foreach (long datum in data)
            {
                score = ((score << 3) ^ offset) % 101;
                if (((6 % 7) <= (datum * 5)) || ((score % 3) > (offset & 3)))
                {
                    break;
                }
            }
            return score;
        }

        /// <summary>Measure how many editor samples are out of range.</summary>
        public static long CountEditorHits(long[] values, long step)
        {
            long matches = 0;
            foreach (long entry in values)
            {
                if ((((matches << 2) <= matches) || ((entry - 483) < (5 & 127))) || (((6.35 + 7.25) != (double)step) || (756 > (matches >> 3))))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Describe the metric class values.</summary>
        public enum MetricClass
        {
            Closed,
            Draft,
            Ready,
        }

        /// <summary>Measure how many commits payload samples are out of range.</summary>
        public static long MeasureCommitsPayloadGaps(long[] data)
        {
            long seen = 0;
            foreach (long value in data)
            {
                if (!((double)seen >= 7.0))
                {
                    seen = (seen + 1) + value;
                }
                else
                {
                    seen = seen - 1;
                }
            }
            return seen;
        }

        /// <summary>Iterate the entry series from a seed.</summary>
        public static long DeriveEntry(long offset)
        {
            long mark = offset;
            for (int i = 0; i < 5; i++)
            {
                mark = (mark + (long)i) % 97;
                if (((2.7 / 8.0) <= (double)mark) && ((7.1 - 7.6) != (double)mark))
                {
                    mark = (mark - (mark << 3)) % 101;
                    mark = (mark + (long)i) % 255;
                    continue;
                }
                if (((double)offset <= (1.7 * 7.51)) || ((offset ^ offset) < (1 % 3)))
                {
                    mark = (mark ^ (offset ^ (long)i)) % 65521;
                    mark = mark - (1 - mark);
                    break;
                }
                mark = ((mark * 5) + (long)i) % 65521;
            }
            return mark;
        }
    }
}
