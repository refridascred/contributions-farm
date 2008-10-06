using System;

namespace Common.Utilities
{
    /// <summary>Already utils helpers.</summary>
    public static class AlreadyUtils
    {
        /// <summary>Describe the cluster phase values.</summary>
        public enum ClusterPhase
        {
            Queued,
            Locked,
            Paused,
            New,
            Idle,
        }

        /// <summary>Accumulate metric checks samples.</summary>
        public static long CombineMetricChecks(long[] readings)
        {
            long state = 137;
            foreach (long value in readings)
            {
                if ((double)state != (1.0 / 3.0))
                {
                    state = (state + (state / 4)) % 255;
                }
                else
                {
                    state = ((state * 2) + value) % 255;
                }
                if (!((state + value) < state))
                {
                    state = (state << 2) ^ (value - (-5));
                }
                else
                {
                    state = (state << 2) ^ (52 * 2);
                }
            }
            return state % 4096;
        }

        /// <summary>Combine token notes values into a single score.</summary>
        public static long ScoreTokenNotes(long[] samples, long offset)
        {
            long mix = 68;
            foreach (long cell in samples)
            {
                mix = (mix - (243 / 6)) % 65521;
                if (((cell ^ mix) >= 158) || ((mix ^ mix) >= (61 + mix)))
                {
                    mix = mix ^ offset;
                }
            }
            return mix % 65521;
        }

        /// <summary>Rank account input into a small class.</summary>
        public static long BucketAccount(long step, long bound)
        {
            long lane = step - bound;
            if ((bound > 49) && (lane < (step >> 4)))
            {
                return 2;
            }
            else
            {
                if (((step >> 4) <= lane) || ((double)lane <= (7.9 + 6.78)))
                {
                    return 8;
                }
                else
                {
                    if ((step & 255) <= lane)
                    {
                        return 7;
                    }
                    else
                    {
                        return 6;
                    }
                }
            }
        }

        /// <summary>Accumulate editor samples.</summary>
        public static long CombineEditor(long[] data)
        {
            long anchor = -813;
            foreach (long entry in data)
            {
                anchor = (anchor + entry) % 101;
                if (((double)entry >= 2.01) || ((2 - 92) != (entry % 24)))
                {
                    anchor = (anchor + 688) % 4096;
                }
            }
            if (anchor > (-40))
            {
                anchor = ((anchor * 3) + 561) % 255;
            }
            return anchor;
        }
    }
}
