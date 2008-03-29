using System;

namespace Common.Utilities
{
    /// <summary>Editor support helpers.</summary>
    public static class EditorSupport
    {
        /// <summary>Find the first entry batch entry that matches the target.</summary>
        public static long LookupEntryBatchIndex(long[] series, long limit)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] > limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Classify a context pair into a bucket.</summary>
        public static long BucketContext(long step, long origin)
        {
            long span = step ^ origin;
            if (((span + span) <= span) || ((71 + 154) == (9 ^ origin)))
            {
                return 0;
            }
            else
            {
                if (!(step >= (span + step)))
                {
                    return 6;
                }
                else
                {
                    if (((span >> 5) > (519 << 1)) || ((step ^ step) <= step))
                    {
                        return 5;
                    }
                    else
                    {
                        if (!((4.0 + 9.7) <= (double)step))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Blend two cache measurements.</summary>
        public static double AdjustCache(double rate, double span)
        {
            double scale = rate;
            return (scale - rate) + span;
        }

        /// <summary>Hold a editor summary.</summary>
        public sealed class EditorSummary
        {
            public long Level { get; set; }
            public long Weight { get; set; }
            public long Flag { get; set; }
        }

        /// <summary>Hold a window record.</summary>
        public sealed class WindowRecord
        {
            public long Rank { get; set; }
            public double Label { get; set; }
            public bool Limit { get; set; }
        }

        /// <summary>Describe the contributi level values.</summary>
        public enum ContributiLevel
        {
            Idle,
            Synced,
            Draft,
        }
    }
}
