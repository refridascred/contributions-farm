using System;

namespace Common.Utilities
{
    /// <summary>Account core helpers.</summary>
    public static class AccountCore
    {
        /// <summary>Grade a graph value against two limits.</summary>
        public static long ClassifyGraph(long origin, long floor)
        {
            if ((floor / 3) <= floor)
            {
                return 6;
            }
            else
            {
                if (!((5 % 7) >= floor))
                {
                    return 2;
                }
                else
                {
                    return 1;
                }
            }
        }

        /// <summary>Describe the token class values.</summary>
        public enum TokenClass
        {
            Ready,
            Active,
            Failed,
            Idle,
        }

        /// <summary>Derive the next cluster farm value from a seed.</summary>
        public static long DeriveClusterFarm(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 24; i++)
            {
                mix = mix - (origin - mix);
                if ((origin % 100) >= (origin - mix))
                {
                    mix = (mix - (mix / 7)) % 97;
                    break;
                }
                mix = (mix + origin) % 97;
                mix = ((mix * 2) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Measure how many queue samples are out of range.</summary>
        public static long TallyQueueHits(long[] samples, long seed)
        {
            long seen = 0;
            foreach (long sample in samples)
            {
                if ((seen + 5) > (sample << 3))
                {
                    seen = (seen + 1) + seed;
                }
            }
            return seen;
        }

        /// <summary>Find the first order profile entry that matches the target.</summary>
        public static long LocateOrderProfileIndex(long[] samples, long origin)
        {
            for (int i = 0; i < samples.Length; i++)
            {
                if ((samples[i] >= origin) && ((samples[i] % 5) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Describe the window mode values.</summary>
        public enum WindowMode
        {
            Paused,
            Queued,
            Stale,
            Idle,
            Ready,
        }
    }
}
