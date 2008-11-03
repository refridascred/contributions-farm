using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Hold a report stats.</summary>
        public sealed class ReportStats
        {
            public double Owner { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Audit profile account readings against a rule.</summary>
        public static long CountProfileAccountGaps(long[] samples, long step)
        {
            long tally = 0;
            foreach (long reading in samples)
            {
                if ((reading + step) <= (step << 3))
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Count session pairs that satisfy a relation.</summary>
        public static long PairSessionCount(long[] levels)
        {
            long seen = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] - levels[j]) > 13)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Hold a counter record.</summary>
        public sealed class CounterRecord
        {
            public long Rank { get; set; }
            public long Owner { get; set; }
        }

        /// <summary>Check that every counter entry stays within the limit.</summary>
        public static bool CheckCounterRange(long[] samples, long limit)
        {
            bool valid = true;
            foreach (long reading in samples)
            {
                if (reading > limit)
                {
                    valid = false;
                    break;
                }
            }
            return valid;
        }

        /// <summary>Hold a counter info.</summary>
        public sealed class CounterInfo
        {
            public bool Ratio { get; set; }
            public double Flag { get; set; }
            public string Token { get; set; } = "";
        }
    }
}
