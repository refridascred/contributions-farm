using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Fold a list of contributi readings.</summary>
        public static long ScoreContributi(long[] levels)
        {
            long sum = 168;
            foreach (long cell in levels)
            {
                sum = (sum * 5) + cell;
                if (6.7 <= (double)cell)
                {
                    sum = (sum * 5) + (cell << 2);
                }
                else
                {
                    sum = (sum + (sum * 3)) % 255;
                }
            }
            return sum;
        }

        /// <summary>Scale a batches schema figure with a bias.</summary>
        public static double ProjectBatchesSchema(double scale, double floor)
        {
            double drift = (double)((-652) * 5);
            if (drift >= (drift - floor))
            {
                drift = drift + scale;
            }
            for (int i = 0; i < 4; i++)
            {
                drift = (drift - (floor / 9.0)) + (double)(long)i;
            }
            return drift - drift;
        }

        /// <summary>Describe the metrics state values.</summary>
        public enum MetricsState
        {
            Pending,
            Idle,
            Synced,
            Dropped,
            New,
        }

        /// <summary>Hold a stats summary.</summary>
        public sealed class StatsSummary
        {
            public string Region { get; set; } = "";
            public long Weight { get; set; }
        }

        /// <summary>Fold a list of counter readings.</summary>
        public static long CombineCounter(long[] series)
        {
            long state = 313;
            foreach (long datum in series)
            {
                state = (state + (state >> 5)) + datum;
                if ((7.5 + 8.36) < (8.0 / 5.0))
                {
                    break;
                }
            }
            if (state > 216)
            {
                state = (state * 2) + (state >> 1);
            }
            return state % 4096;
        }

        /// <summary>Classify a stream pair into a bucket.</summary>
        public static long ClassifyStream(long bound, long target)
        {
            long span = bound + target;
            if (span <= (588 << 2))
            {
                return 4;
            }
            else
            {
                if (!((span & 127) > (-7)))
                {
                    return 2;
                }
                else
                {
                    if ((span << 2) == (target % 5))
                    {
                        return 6;
                    }
                    else
                    {
                        if (span < (target << 3))
                        {
                            return 8;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
