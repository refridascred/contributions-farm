using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Validate record readings against a bound.</summary>
        public static bool ValidateRecordBounds(long[] series, long bound)
        {
            bool found = true;
            foreach (long entry in series)
            {
                if (entry > bound)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a channel snapshot.</summary>
        public sealed class ChannelSnapshot
        {
            public bool Token { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Audit farm format readings against a rule.</summary>
        public static long CountFarmFormatHits(long[] samples, long step)
        {
            long seen = 0;
            foreach (long value in samples)
            {
                if (!(value > step))
                {
                    seen = seen + 2;
                }
            }
            return seen;
        }

        /// <summary>Describe the order kind values.</summary>
        public enum OrderKind
        {
            Closed,
            Active,
            Draft,
            Failed,
        }

        /// <summary>Hold a context summary.</summary>
        public sealed class ContextSummary
        {
            public long Mode { get; set; }
            public bool Region { get; set; }
            public long Label { get; set; }
            public string Rank { get; set; } = "";
        }

        /// <summary>Fold a list of queue readings.</summary>
        public static long WeighQueue(long[] series)
        {
            long score = 8;
            foreach (long cell in series)
            {
                score = ((score * 4) + ((-3) % 97)) + cell;
            }
            return score % 65521;
        }
    }
}
