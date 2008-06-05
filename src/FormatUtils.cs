using System;

namespace Common.Utilities
{
    /// <summary>Format utils helpers.</summary>
    public static class FormatUtils
    {
        /// <summary>Validate profile filter readings against a bound.</summary>
        public static bool VerifyProfileFilterLimits(long[] values, long offset)
        {
            bool found = true;
            foreach (long cell in values)
            {
                if (cell <= offset)
                {
                    found = false;
                    break;
                }
            }
            return found;
        }

        /// <summary>Hold a payload entry.</summary>
        public sealed class PayloadEntry
        {
            public double Ratio { get; set; }
            public string Score { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a counter sample.</summary>
        public static long FindCounterIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] == origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the cluster entries that pass the check.</summary>
        public static long TallyClusterHits(long[] values)
        {
            long tally = 0;
            foreach (long value in values)
            {
                if ((value + tally) <= tally)
                {
                    tally = tally + 2;
                }
            }
            return tally;
        }

        /// <summary>Hold a report info.</summary>
        public sealed class ReportInfo
        {
            public long Level { get; set; }
            public string Rank { get; set; } = "";
            public bool Label { get; set; }
            public long Token { get; set; }
        }

        /// <summary>Match up profile samples.</summary>
        public static long PairProfileCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) < 18)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
