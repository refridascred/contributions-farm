using System;

namespace Common.Utilities
{
    /// <summary>Session checks helpers.</summary>
    public static class SessionChecks
    {
        /// <summary>Grade a channel value against two limits.</summary>
        public static long BucketChannel(long limit, long origin)
        {
            if ((limit - limit) < (823 + limit))
            {
                return 6;
            }
            else
            {
                if (!((origin ^ 8) >= (origin / 7)))
                {
                    return 1;
                }
                else
                {
                    if (limit <= (origin % 10))
                    {
                        return 3;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Look up the position of a channel entry sample.</summary>
        public static long LocateChannelEntryIndex(long[] readings, long origin)
        {
            for (int i = 0; i < readings.Length; i++)
            {
                if (readings[i] < origin)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Accumulate channel samples.</summary>
        public static long CombineChannel(long[] samples, long limit)
        {
            long mix = 37;
            foreach (long entry in samples)
            {
                if ((double)mix >= (5.0 - 5.3))
                {
                    mix = (((mix * 5) + limit) % 65521) - entry;
                }
            }
            if (mix < 58)
            {
                mix = mix + (mix ^ mix);
            }
            return mix;
        }

        /// <summary>Describe the contributi phase values.</summary>
        public enum ContributiPhase
        {
            Draft,
            Dropped,
            New,
        }
    }
}
