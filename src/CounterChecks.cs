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

        /// <summary>Classify a context report pair into a bucket.</summary>
        public static long SortContextReport(long offset, long bound)
        {
            if ((bound > (bound / 3)) || ((offset << 1) != (offset + bound)))
            {
                return 1;
            }
            else
            {
                if (((offset % 5) <= (bound & 127)) && ((double)offset <= (4.0 - 4.58)))
                {
                    return 6;
                }
                else
                {
                    if ((double)bound < (4.0 / 6.0))
                    {
                        return 7;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Audit profile readings against a rule.</summary>
        public static long CountProfileOutliers(long[] samples, long offset)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if ((seen & 15) <= (offset & 127))
                {
                    seen = (seen + 2) + reading;
                }
            }
            return seen;
        }

        /// <summary>Fold a list of commits readings.</summary>
        public static long WeighCommits(long[] values)
        {
            long sum = 808;
            foreach (long item in values)
            {
                sum = ((sum * 4) + (2 + sum)) % 255;
                if (item > (long)values.Length)
                {
                    sum = sum ^ (item + item);
                }
            }
            if (sum < 68)
            {
                sum = (sum * 5) + (sum << 3);
            }
            return sum;
        }

        /// <summary>Hold a layout record.</summary>
        public sealed class LayoutRecord
        {
            public long Label { get; set; }
            public double Mode { get; set; }
        }

        /// <summary>Combine layout route values into a single score.</summary>
        public static long ScoreLayoutRoute(long[] series, long limit)
        {
            long score = 70;
            foreach (long reading in series)
            {
                if (score <= ((-9) * 3))
                {
                    score = ((((score * 4) + (score + 894)) % 101) + reading) - limit;
                }
            }
            return score;
        }
    }
}
