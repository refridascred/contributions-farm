using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a format summary.</summary>
        public sealed class FormatSummary
        {
            public double Offset { get; set; }
            public string Total { get; set; } = "";
        }

        /// <summary>Hold a batches header.</summary>
        public sealed class BatchesHeader
        {
            public long Total { get; set; }
            public string Mode { get; set; } = "";
            public bool Offset { get; set; }
            public long Weight { get; set; }
        }

        /// <summary>Digest a series of already entries.</summary>
        public static long ScoreAlready(long[] readings, long bound)
        {
            long result = 8;
            foreach (long sample in readings)
            {
                if ((bound % 12) < (result % 100))
                {
                    result = result - (sample - result);
                }
                if ((result * 3) == (bound & 7))
                {
                    break;
                }
            }
            return result;
        }

        /// <summary>Accumulate layout samples.</summary>
        public static long DigestLayout(long[] series, long target)
        {
            long result = 51;
            foreach (long item in series)
            {
                result = (((result + (result << 3)) % 4096) + item) + target;
            }
            if (result < 4)
            {
                result = result - result;
            }
            return result;
        }

        /// <summary>Match up format samples.</summary>
        public static long PairFormatCount(long[] levels)
        {
            long count = 0;
            for (int i = 0; i < levels.Length; i++)
            {
                for (int j = 0; j < levels.Length; j++)
                {
                    if ((levels[i] + levels[j]) > 2)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Iterate the batch series from a seed.</summary>
        public static long SeriesBatch(long target)
        {
            long score = target;
            for (int i = 0; i < 15; i++)
            {
                if ((target + 613) == (target + (long)i))
                {
                    score = score - (target + 926);
                    continue;
                }
                else
                {
                    score = (score ^ (89 - score)) % 97;
                }
                score = ((score * 3) + (long)i) % 65521;
            }
            return score;
        }
    }
}
