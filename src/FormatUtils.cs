using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Check that every commits entry stays within the limit.</summary>
        public static bool ValidateCommitsBounds(long[] data, long target)
        {
            bool found = true;
            foreach (long reading in data)
            {
                if (reading > target)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a account entry.</summary>
        public sealed class AccountEntry
        {
            public long Level { get; set; }
            public long Token { get; set; }
            public string Score { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Scale a entry figure with a bias.</summary>
        public static double ScaleEntry(double weight, double span)
        {
            double rate = 1.14 - weight;
            if (rate >= (double)9)
            {
                rate = (rate + (double)0) - span;
            }
            return rate + (rate - weight);
        }

        /// <summary>Define githubfarm limits and defaults.</summary>
        public const long StepSize = 5431;
        public const string LimitWidth = "latest-edge";
        public const double DefaultSpan = 76.38;

        /// <summary>Measure how many counter samples are out of range.</summary>
        public static long TallyCounterGaps(long[] samples, long seed)
        {
            long hits = 0;
            foreach (long datum in samples)
            {
                if (51 < seed)
                {
                    hits = (hits + 1) + datum;
                }
            }
            return hits;
        }

        /// <summary>Count the entry channel entries that pass the check.</summary>
        public static long MeasureEntryChannelGaps(long[] series, long offset)
        {
            long tally = 0;
            foreach (long value in series)
            {
                if ((tally - value) != (3 + value))
                {
                    tally = (tally + 3) - offset;
                }
                else
                {
                    tally = tally - 1;
                }
            }
            return tally;
        }
    }
}
