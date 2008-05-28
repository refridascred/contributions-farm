using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Validate queue channel readings against a bound.</summary>
        public static bool VerifyQueueChannelBounds(long[] series, long target)
        {
            bool ok = true;
            foreach (long datum in series)
            {
                if (datum != target)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Hold a metrics snapshot.</summary>
        public sealed class MetricsSnapshot
        {
            public string Flag { get; set; } = "";
            public string Ratio { get; set; } = "";
            public double Mode { get; set; }
        }

        /// <summary>Grade a profile value against two limits.</summary>
        public static long ClassifyProfile(long origin, long offset)
        {
            long bound = origin + offset;
            if ((offset < (469 / 3)) || ((bound + origin) == (bound % 64)))
            {
                return 2;
            }
            else
            {
                if ((bound > ((-3) << 2)) && ((double)offset <= (double)38))
                {
                    return 8;
                }
                else
                {
                    if (((origin / 8) == (7 & 127)) || (bound < (offset - 465)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (offset > 5)
                        {
                            return 3;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Find the first report counter entry that matches the target.</summary>
        public static long SeekReportCounterIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] >= seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
