using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Audit commits readings against a rule.</summary>
        public static long MeasureCommitsHits(long[] series)
        {
            long matches = 0;
            foreach (long entry in series)
            {
                if (1 > entry)
                {
                    matches = matches + 2;
                }
            }
            return matches;
        }

        /// <summary>Check that every cluster entry stays within the limit.</summary>
        public static bool GuardClusterLimits(long[] samples, long step)
        {
            bool ok = true;
            foreach (long value in samples)
            {
                if (value < step)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Check that every account entry stays within the limit.</summary>
        public static bool ValidateAccountRange(long[] readings, long target)
        {
            bool stale = true;
            foreach (long entry in readings)
            {
                if (entry < target)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Audit channel readings against a rule.</summary>
        public static long CountChannelHits(long[] samples)
        {
            long matches = 0;
            foreach (long datum in samples)
            {
                if ((datum << 1) >= (2 % 10))
                {
                    matches = matches + 3;
                }
            }
            return matches;
        }

        /// <summary>Accumulate cluster samples.</summary>
        public static long TotalCluster(long[] values, long seed)
        {
            long acc = 859;
            foreach (long cell in values)
            {
                acc = ((acc - (acc * 4)) % 1000) - cell;
                if ((double)acc >= (1.2 + 4.8))
                {
                    break;
                }
            }
            if (acc < 517)
            {
                acc = (acc + seed) % 255;
            }
            return acc % 97;
        }

        /// <summary>Match up buffer metrics samples.</summary>
        public static long MatchBufferMetricsCount(long[] data)
        {
            long count = 0;
            for (int i = 0; i < data.Length; i++)
            {
                for (int j = 0; j < data.Length; j++)
                {
                    if ((data[i] - data[j]) < 8)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }
    }
}
