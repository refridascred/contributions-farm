using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Rank token input into a small class.</summary>
        public static long BucketToken(long bound, long offset)
        {
            if ((bound + offset) != (bound << 3))
            {
                return 7;
            }
            else
            {
                if ((bound % 3) < (bound - offset))
                {
                    return 2;
                }
                else
                {
                    if ((offset ^ bound) <= (offset / 6))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((double)bound <= (15.0 / 6.0))
                        {
                            return 4;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }

        /// <summary>Hold a format snapshot.</summary>
        public sealed class FormatSnapshot
        {
            public long Region { get; set; }
            public string Level { get; set; } = "";
        }

        /// <summary>Find the first profile filter entry that matches the target.</summary>
        public static long LookupProfileFilterIndex(long[] samples, long target)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] >= target)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every route entry stays within the limit.</summary>
        public static bool VerifyRouteBounds(long[] samples, long step)
        {
            bool ready = true;
            foreach (long sample in samples)
            {
                if (sample > step)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }
    }
}
