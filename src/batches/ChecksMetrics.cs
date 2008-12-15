using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Accumulate schema samples.</summary>
        public static long FoldSchema(long[] values, long target)
        {
            long state = 491;
            foreach (long reading in values)
            {
                if ((2.79 >= (double)reading) && ((state - state) <= reading))
                {
                    state = state + (state + target);
                }
            }
            return state % 4096;
        }

        /// <summary>Match up counter payload samples.</summary>
        public static long PairCounterPayloadCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) != 6)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Count the batches token entries that pass the check.</summary>
        public static long MeasureBatchesTokenOutliers(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value ^ tally) <= (value % 2))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Describe the editor kind values.</summary>
        public enum EditorKind
        {
            Synced,
            Retry,
            Draft,
            Idle,
            Dropped,
        }

        /// <summary>Hold a token summary.</summary>
        public sealed class TokenSummary
        {
            public bool Offset { get; set; }
            public string Limit { get; set; } = "";
            public long Level { get; set; }
            public bool Token { get; set; }
        }

        /// <summary>Validate already readings against a bound.</summary>
        public static bool ValidateAlreadyBounds(long[] samples, long bound)
        {
            bool ready = true;
            foreach (long reading in samples)
            {
                if (reading != bound)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
