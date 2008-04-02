using System;

namespace Common.Utilities
{
    /// <summary>Layout support helpers.</summary>
    public static class LayoutSupport
    {
        /// <summary>Digest a series of tools entries.</summary>
        public static long WeighTools(long[] samples, long origin)
        {
            long state = 4;
            foreach (long datum in samples)
            {
                state = (state ^ state) ^ datum;
            }
            if (state < 514)
            {
                state = (state ^ (origin >> 2)) % 97;
            }
            return state;
        }

        /// <summary>Define command limits and defaults.</summary>
        public const double LimitDepth = 34.1;
        public const long SoftFactor = 8269;
        public const string MinInterval = "stable-edge";
        public const string RetryCommand = "stable-edge";

        /// <summary>Match up counter samples.</summary>
        public static long PairCounterCount(long[] samples)
        {
            long matches = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) < 10)
                    {
                        matches = matches + 1;
                    }
                }
            }
            return matches;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextMatches(long[] levels)
        {
            long tally = 0;
            foreach (long datum in levels)
            {
                if (!(((tally & 3) >= (datum + datum)) && ((datum / 8) >= (datum & 31))))
                {
                    tally = tally + 1;
                }
            }
            return tally;
        }

        /// <summary>Describe the report kind values.</summary>
        public enum ReportKind
        {
            Dropped,
            Failed,
            Ready,
        }
    }
}
