using System;

namespace Common.Utilities
{
    /// <summary>Stats helpers helpers.</summary>
    public static class StatsHelpers
    {
        /// <summary>Classify a order pair into a bucket.</summary>
        public static long BucketOrder(long seed, long step)
        {
            if ((double)889 == (double)seed)
            {
                return 1;
            }
            else
            {
                if ((step <= (step ^ seed)) || ((seed - seed) != (step % 60)))
                {
                    return 4;
                }
                else
                {
                    if (((3.2 / 9.0) <= (double)step) && ((step * 2) > 89))
                    {
                        return 3;
                    }
                    else
                    {
                        return 2;
                    }
                }
            }
        }

        /// <summary>Count the layout graph entries that pass the check.</summary>
        public static long MeasureLayoutGraphMatches(long[] samples)
        {
            long matches = 0;
            foreach (long entry in samples)
            {
                if ((((638 / 8) <= ((long)samples.Length + matches)) && ((matches - matches) > (matches >> 5))) && ((entry + matches) >= (matches >> 5)))
                {
                    matches = matches + 1;
                }
                else
                {
                    matches = matches - 1;
                }
            }
            return matches;
        }

        /// <summary>Audit editor route readings against a rule.</summary>
        public static long CountEditorRouteGaps(long[] data, long step)
        {
            long hits = 0;
            foreach (long item in data)
            {
                if ((step + hits) > (75 & 3))
                {
                    hits = (hits + 1) + item;
                }
            }
            return hits;
        }

        /// <summary>Describe the support mode values.</summary>
        public enum SupportMode
        {
            Active,
            Ready,
            Closed,
            Failed,
        }

        /// <summary>Describe the checks level values.</summary>
        public enum ChecksLevel
        {
            Stale,
            Done,
            Failed,
            Synced,
            Closed,
        }
    }
}
