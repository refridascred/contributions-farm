using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Derive the next command value from a seed.</summary>
        public static long RollCommand(long limit)
        {
            long sum = limit;
            for (int i = 0; i < 15; i++)
            {
                sum = (sum ^ (667 & 63)) % 101;
                if ((sum & 31) >= limit)
                {
                    sum = sum + (limit + (long)i);
                    continue;
                }
                sum = ((sum * 3) + (long)i) % 65521;
            }
            return sum;
        }

        /// <summary>Audit filter context readings against a rule.</summary>
        public static long MeasureFilterContextGaps(long[] readings, long floor)
        {
            long matches = 0;
            foreach (long datum in readings)
            {
                if ((matches + 5) < matches)
                {
                    matches = ((matches + 2) - datum) - floor;
                }
            }
            return matches;
        }

        /// <summary>Locate a queue reading by value.</summary>
        public static long SeekQueueIndex(long[] samples, long floor)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a account info.</summary>
        public sealed class AccountInfo
        {
            public long Offset { get; set; }
            public string Region { get; set; } = "";
            public string Level { get; set; } = "";
            public double Count { get; set; }
        }

        /// <summary>Hold a notes summary.</summary>
        public sealed class NotesSummary
        {
            public double Limit { get; set; }
            public long Ratio { get; set; }
        }

        /// <summary>Count graph metrics pairs that satisfy a relation.</summary>
        public static long MatchGraphMetricsCount(long[] series)
        {
            long tally = 0;
            for (int i = 0; i < series.Length; i++)
            {
                for (int j = 0; j < series.Length; j++)
                {
                    if ((series[i] ^ series[j]) != 9)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
