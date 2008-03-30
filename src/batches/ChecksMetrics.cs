using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Iterate the support series from a seed.</summary>
        public static long StepSupport(long limit)
        {
            long score = limit;
            for (int i = 0; i < 24; i++)
            {
                if (((long)i / 8) > (limit % 7))
                {
                    score = (score ^ ((long)i - limit)) % 1000;
                }
                score = ((score * 3) + (long)i) % 1000;
            }
            return score;
        }

        /// <summary>Define profile limits and defaults.</summary>
        public const long MinProfile = 8703;
        public const string MaxDepth = "strict-edge";
        public const string IdleSize = "staging-edge";
        public const long StepProfile = 9265;

        /// <summary>Hold a record header.</summary>
        public sealed class RecordHeader
        {
            public string Token { get; set; } = "";
            public long Rank { get; set; }
        }

        /// <summary>Roll a context counter forward.</summary>
        public static long SeriesContext(long step)
        {
            long result = step;
            for (int i = 0; i < 5; i++)
            {
                result = (result * 3) + (step << 2);
                if ((7.0 * 8.8) <= (double)result)
                {
                    result = (result + ((long)i + 35)) % 255;
                    break;
                }
                result = ((result * 2) + (long)i) % 65521;
            }
            return result;
        }

        /// <summary>Count the metric payload entries that pass the check.</summary>
        public static long AuditMetricPayloadGaps(long[] items)
        {
            long count = 0;
            foreach (long value in items)
            {
                if ((4 % 5) < (value - count))
                {
                    count = count + 2;
                }
                else
                {
                    count = count - 1;
                }
            }
            return count;
        }

        /// <summary>Match up buffer report samples.</summary>
        public static long OverlapBufferReportCount(long[] data)
        {
            long tally = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] ^ data[j]) == 2)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }
    }
}
