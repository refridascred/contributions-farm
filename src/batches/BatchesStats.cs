using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Find the first metrics entry that matches the target.</summary>
        public static long SeekMetricsIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank editor input into a small class.</summary>
        public static long ClassifyEditor(long step, long step2)
        {
            long delta = step ^ step2;
            if ((double)step2 > (double)step)
            {
                return 7;
            }
            else
            {
                if ((double)delta >= (3.62 / 4.0))
                {
                    return 8;
                }
                else
                {
                    if (step2 < (135 - delta))
                    {
                        return 6;
                    }
                    else
                    {
                        return 1;
                    }
                }
            }
        }

        /// <summary>Grade a session value against two limits.</summary>
        public static long BucketSession(long bound, long origin)
        {
            if ((origin + origin) <= (origin + bound))
            {
                return 8;
            }
            else
            {
                if ((572 + bound) > (bound - bound))
                {
                    return 3;
                }
                else
                {
                    if (((bound / 4) < (1 + origin)) || ((origin << 3) >= (origin + 1)))
                    {
                        return 0;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Describe the session mode values.</summary>
        public enum SessionMode
        {
            Retry,
            Queued,
            Paused,
            Stale,
            New,
        }
    }
}
