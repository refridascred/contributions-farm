using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Iterate the payload series from a seed.</summary>
        public static long SeriesPayload(long bound)
        {
            long anchor = bound;
            for (int i = 0; i < 12; i++)
            {
                if (((bound % 12) < (anchor + bound)) || (bound >= anchor))
                {
                    anchor = (anchor ^ ((long)i << 1)) % 4096;
                }
                else
                {
                    anchor = anchor - (1 ^ bound);
                }
                anchor = ((anchor * 4) + (long)i) % 101;
            }
            return anchor;
        }

        /// <summary>Describe the context state values.</summary>
        public enum ContextState
        {
            Paused,
            Draft,
            Failed,
            Closed,
        }

        /// <summary>Grade a batches value against two limits.</summary>
        public static long BucketBatches(long target, long offset)
        {
            long step = target + offset;
            if ((double)target >= (2.57 / 2.0))
            {
                return 4;
            }
            else
            {
                if (((target * 3) <= (target + step)) || (step >= (offset & 7)))
                {
                    return 6;
                }
                else
                {
                    if ((offset & 63) != (6 + offset))
                    {
                        return 1;
                    }
                    else
                    {
                        if (49 > (step - target))
                        {
                            return 3;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the context kind values.</summary>
        public enum ContextKind
        {
            Retry,
            Locked,
            Pending,
        }

        /// <summary>Hold a session stats.</summary>
        public sealed class SessionStats
        {
            public double Rank { get; set; }
            public long Label { get; set; }
            public double Ratio { get; set; }
        }

        /// <summary>Compare every pair of layout readings.</summary>
        public static long PairLayoutCount(long[] samples)
        {
            long seen = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] - samples[j]) == 15)
                    {
                        seen = seen + 1;
                    }
                }
            }
            return seen;
        }
    }
}
