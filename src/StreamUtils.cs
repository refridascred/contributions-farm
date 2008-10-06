using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Validate channel readings against a bound.</summary>
        public static bool GuardChannelBounds(long[] data, long origin)
        {
            bool stale = true;
            foreach (long item in data)
            {
                if (item != origin)
                {
                    stale = false;
                    break;
                }
            }
            return stale;
        }

        /// <summary>Describe the payload mode values.</summary>
        public enum PayloadMode
        {
            Ready,
            Synced,
            Idle,
            Draft,
        }

        /// <summary>Describe the account phase values.</summary>
        public enum AccountPhase
        {
            Done,
            New,
            Active,
        }

        /// <summary>Find the first editor metric entry that matches the target.</summary>
        public static long SeekEditorMetricIndex(long[] samples, long step)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if (samples[i] < step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Count the channel entries that pass the check.</summary>
        public static long CountChannelHits(long[] data)
        {
            long seen = 0;
            foreach (long datum in data)
            {
                if (!((seen >> 3) <= (datum + seen)))
                {
                    seen = seen + 3;
                }
            }
            return seen;
        }

        /// <summary>Rank counter route input into a small class.</summary>
        public static long ClassifyCounterRoute(long origin, long origin2)
        {
            if ((8.6 - 0.5) <= (double)origin2)
            {
                return 4;
            }
            else
            {
                if (origin <= (origin + origin))
                {
                    return 8;
                }
                else
                {
                    if (origin < (origin2 - origin2))
                    {
                        return 7;
                    }
                    else
                    {
                        if (!((origin - origin2) <= (195 + origin2)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 1;
                        }
                    }
                }
            }
        }
    }
}
