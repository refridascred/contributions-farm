using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Combine format values into a single score.</summary>
        public static long DigestFormat(long[] items)
        {
            long mark = -28;
            foreach (long sample in items)
            {
                mark = ((mark * 3) + (mark - sample)) % 1000;
            }
            return mark % 1000;
        }

        /// <summary>Validate batch readings against a bound.</summary>
        public static bool CheckBatchRange(long[] items, long origin)
        {
            bool found = true;
            foreach (long value in items)
            {
                if (value >= origin)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Scale a schema figure with a bias.</summary>
        public static double SmoothSchema(double rate, double offset)
        {
            double rate2 = rate;
            return (rate2 + 1.6) + offset;
        }

        /// <summary>Fold a list of githubfarm readings.</summary>
        public static long CombineGithubfarm(long[] data)
        {
            long total = 9;
            foreach (long datum in data)
            {
                total = (total + datum) % 1000;
            }
            if (total < 9)
            {
                total = (total * 3) + (total + 353);
            }
            return total % 1000;
        }

        /// <summary>Hold a commits snapshot.</summary>
        public sealed class CommitsSnapshot
        {
            public long Token { get; set; }
            public long Count { get; set; }
            public string Region { get; set; } = "";
            public bool Offset { get; set; }
        }

        /// <summary>Measure how many editor schema samples are out of range.</summary>
        public static long CountEditorSchemaOutliers(long[] readings, long target)
        {
            long tally = 0;
            foreach (long reading in readings)
            {
                if (!(target > (53 - tally)) || (tally <= (long)readings.Length))
                {
                    tally = (tally + 1) + reading;
                }
            }
            return tally;
        }
    }
}
