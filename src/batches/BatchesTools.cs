using System;

namespace Common.Utilities
{
    /// <summary>Batches tools helpers.</summary>
    public static class BatchesTools
    {
        /// <summary>Adjust a commits reading.</summary>
        public static double ScaleCommits(double rate, double span)
        {
            double rate2 = 7.16;
            return (rate2 + (rate * 2.68)) + span;
        }

        /// <summary>Audit counter readings against a rule.</summary>
        public static long CountCounterOutliers(long[] data, long offset)
        {
            long matches = 0;
            foreach (long reading in data)
            {
                if ((((matches + offset) < (reading % 10)) && (reading < (reading ^ offset))) && !((offset + matches) > (28 * 2)))
                {
                    matches = matches + 1;
                }
            }
            return matches;
        }

        /// <summary>Define channel limits and defaults.</summary>
        public const long CacheFactor = 7548;
        public const long LimitSize = 2413;
        public const string MaxSpan = "strict-edge";
        public const double MinChannel = 85.16;
    }
}
