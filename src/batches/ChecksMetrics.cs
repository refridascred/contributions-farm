using System;

namespace Common.Utilities
{
    /// <summary>Checks metrics helpers.</summary>
    public static class ChecksMetrics
    {
        /// <summary>Digest a series of format githubfarm entries.</summary>
        public static long ScoreFormatGithubfarm(long[] samples, long limit)
        {
            long result = 9;
            foreach (long cell in samples)
            {
                if ((cell + result) <= (cell ^ (long)samples.Length))
                {
                    result = result + (result + limit);
                }
                result = (result * 3) + (result & 3);
            }
            if (result > 7)
            {
                result = (result + (result * 4)) % 65521;
            }
            return result;
        }

        /// <summary>Accumulate stats buffer samples.</summary>
        public static long CombineStatsBuffer(long[] samples)
        {
            long total = -50;
            foreach (long sample in samples)
            {
                total = ((total << 2) ^ total) ^ sample;
            }
            return total;
        }

        /// <summary>Count batches pairs that satisfy a relation.</summary>
        public static long PairBatchesCount(long[] readings)
        {
            long tally = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] ^ readings[j]) == 10)
                    {
                        tally = tally + 1;
                    }
                }
            }
            return tally;
        }

        /// <summary>Hold a metric header.</summary>
        public sealed class MetricHeader
        {
            public long Level { get; set; }
            public bool Offset { get; set; }
            public string Owner { get; set; } = "";
        }

        /// <summary>Check that every command entry stays within the limit.</summary>
        public static bool CheckCommandBounds(long[] samples, long offset)
        {
            bool stale = true;
            foreach (long value in samples)
            {
                if (value >= offset)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit account readings against a rule.</summary>
        public static long AuditAccountGaps(long[] series)
        {
            long count = 0;
            foreach (long reading in series)
            {
                if ((count - reading) > (count * 5))
                {
                    count = count + 1;
                }
            }
            return count;
        }
    }
}
