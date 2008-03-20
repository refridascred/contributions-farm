using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Measure how many context samples are out of range.</summary>
        public static long TallyContextOutliers(long[] samples)
        {
            long seen = 0;
            foreach (long reading in samples)
            {
                if (!(reading <= (88 / 9)))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Hold a farm info.</summary>
        public sealed class FarmInfo
        {
            public double Ratio { get; set; }
            public long Score { get; set; }
            public bool Level { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Measure how many window samples are out of range.</summary>
        public static long MeasureWindowGaps(long[] values, long limit)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((tally - tally) >= (value + limit))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Combine notes values into a single score.</summary>
        public static long ScoreNotes(long[] data, long bound)
        {
            long acc = 153;
            foreach (long datum in data)
            {
                if ((bound - datum) > bound)
                {
                    acc = ((acc << 2) ^ acc) % 97;
                }
            }
            if (acc < 217)
            {
                acc = ((acc << 2) ^ (acc - bound)) % 65521;
            }
            return acc;
        }
    }
}
