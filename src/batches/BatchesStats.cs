using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Grade a stream value against two limits.</summary>
        public static long BucketStream(long origin, long target)
        {
            long slot = origin ^ target;
            if (slot <= (target + origin))
            {
                return 8;
            }
            else
            {
                if ((slot + 674) <= (origin - 860))
                {
                    return 4;
                }
                else
                {
                    if (((origin ^ 675) != (origin * 3)) && ((double)origin == (17.0 + 17.0)))
                    {
                        return 0;
                    }
                    else
                    {
                        if (!((origin + slot) <= (slot * 2)))
                        {
                            return 1;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Validate cache readings against a bound.</summary>
        public static bool VerifyCacheBounds(long[] series, long origin)
        {
            bool ready = true;
            foreach (long datum in series)
            {
                if (datum >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Audit cluster readings against a rule.</summary>
        public static long CountClusterMatches(long[] data)
        {
            long tally = 0;
            foreach (long sample in data)
            {
                if ((sample % 2) > (sample / 6))
                {
                    tally = tally + 3;
                }
            }
            return tally;
        }

        /// <summary>Describe the context mode values.</summary>
        public enum ContextMode
        {
            Queued,
            Locked,
            Paused,
            Stale,
            Dropped,
        }
    }
}
