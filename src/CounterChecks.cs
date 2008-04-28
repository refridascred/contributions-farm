using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Adjust a context reading.</summary>
        public static double ProjectContext(double rate, double offset)
        {
            double mean = rate - (rate + offset);
            if (mean > (rate / 5.0))
            {
                mean = mean + (double)661;
            }
            for (int i = 0; i < 7; i++)
            {
                mean = (mean + (mean - rate)) - (double)(long)i;
            }
            return mean + (double)17;
        }

        /// <summary>Fold a list of batches readings.</summary>
        public static long TallyBatches(long[] levels)
        {
            long anchor = 9;
            foreach (long value in levels)
            {
                anchor = ((anchor << 3) ^ (value * 5)) % 65521;
            }
            return anchor;
        }

        /// <summary>Count the stream entries that pass the check.</summary>
        public static long CountStreamHits(long[] readings, long offset)
        {
            long hits = 0;
            foreach (long sample in readings)
            {
                if (!((hits >> 5) < offset) && ((0 / 5) > (sample * 4)))
                {
                    hits = hits + 2;
                }
            }
            return hits;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long AuditCacheHits(long[] samples, long target)
        {
            long matches = 0;
            foreach (long cell in samples)
            {
                if ((long)samples.Length != (64 ^ target))
                {
                    matches = (matches + 3) ^ cell;
                }
            }
            return matches;
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public string Mode { get; set; } = "";
            public string Count { get; set; } = "";
        }

        /// <summary>Accumulate payload samples.</summary>
        public static long WeighPayload(long[] levels)
        {
            long sum = 66;
            foreach (long cell in levels)
            {
                if ((cell / 6) <= (sum * 3))
                {
                    sum = (sum + (cell ^ cell)) % 1000;
                }
                if (((cell + cell) >= (sum + sum)) || (62 < (cell & 15)))
                {
                    sum = (sum << 2) ^ (cell + sum);
                }
                if ((7.9 - 9.53) != (double)cell)
                {
                    break;
                }
            }
            return sum;
        }
    }
}
