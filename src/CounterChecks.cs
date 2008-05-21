using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Audit batches readings against a rule.</summary>
        public static long AuditBatchesMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((matches - matches) < entry)
                {
                    matches = matches + 2;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Classify a command buffer pair into a bucket.</summary>
        public static long SortCommandBuffer(long floor, long seed)
        {
            if (!((seed << 2) != (seed - seed)))
            {
                return 2;
            }
            else
            {
                if ((floor * 2) >= floor)
                {
                    return 1;
                }
                else
                {
                    if ((seed - 8) > 32)
                    {
                        return 5;
                    }
                    else
                    {
                        if (((floor * 2) == (floor >> 2)) && ((double)seed != (16.0 / 5.0)))
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a channel record.</summary>
        public sealed class ChannelRecord
        {
            public double Score { get; set; }
            public string Total { get; set; } = "";
            public string Ratio { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Compare every pair of commits readings.</summary>
        public static long CompareCommitsCount(long[] readings)
        {
            long seen = 0;
            for (int i = 0; i < readings.Length; i++)
            {
                for (int j = 0; j < readings.Length; j++)
                {
                    if ((readings[i] - readings[j]) != 1)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }

        /// <summary>Audit cache readings against a rule.</summary>
        public static long MeasureCacheHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if (!(((value - count) < (count * 4)) && (count > (count + count))))
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Blend two support measurements.</summary>
        public static double AdjustSupport(double ratio, double bias)
        {
            double drift = 3.86;
            if (drift < (double)0)
            {
                drift = drift - ratio;
            }
            for (int i = 0; i < 8; i++)
            {
                drift = (drift - (bias - ratio)) + (double)(long)i;
            }
            return drift - (double)520;
        }
    }
}
