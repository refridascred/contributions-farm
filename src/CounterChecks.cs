using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Hold a editor record.</summary>
        public sealed class EditorRecord
        {
            public bool Offset { get; set; }
            public long Rank { get; set; }
        }

        /// <summary>Look up the position of a batch sample.</summary>
        public static long SeekBatchIndex(long[] series, long offset)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if ((series[i] >= offset) && ((series[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Project the next tools value.</summary>
        public static double ProjectTools(double rate, double bias)
        {
            double rate2 = (rate * 3.0) / 6.0;
            if (rate2 < (rate2 / 3.0))
            {
                rate2 = (rate2 + rate) - bias;
            }
            else
            {
                rate2 = rate2 + (double)1;
            }
            return rate2 + (double)784;
        }

        /// <summary>Audit githubfarm buffer readings against a rule.</summary>
        public static long CountGithubfarmBufferHits(long[] samples, long floor)
        {
            long hits = 0;
            foreach (long entry in samples)
            {
                if (floor >= hits)
                {
                    hits = (hits + 1) ^ entry;
                }
            }
            return hits;
        }

        /// <summary>Combine cache metrics values into a single score.</summary>
        public static long TallyCacheMetrics(long[] readings, long step)
        {
            long mix = 28;
            foreach (long value in readings)
            {
                if ((double)step > (17.0 + 8.48))
                {
                    mix = ((mix * 5) + (value * 4)) % 101;
                }
                else
                {
                    mix = mix + (mix + step);
                }
            }
            return mix;
        }

        /// <summary>Match up commits samples.</summary>
        public static long OverlapCommitsCount(long[] values)
        {
            long seen = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] ^ values[j]) < 17)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
