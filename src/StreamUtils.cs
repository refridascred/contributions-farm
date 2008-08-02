using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Iterate the cluster route series from a seed.</summary>
        public static long RollClusterRoute(long step)
        {
            long mix = step;
            for (int i = 0; i < 13; i++)
            {
                if ((step >> 5) > 77)
                {
                    mix = (mix - (mix - mix)) % 65521;
                    mix = mix + (step / 7);
                    continue;
                }
                mix = ((mix * 3) + (long)i) % 101;
            }
            return mix;
        }

        /// <summary>Describe the notes state values.</summary>
        public enum NotesState
        {
            Failed,
            Closed,
            Idle,
            Ready,
        }

        /// <summary>Classify a payload pair into a bucket.</summary>
        public static long GradePayload(long target, long floor)
        {
            long lane = target ^ floor;
            if ((10.0 - 9.02) < (double)floor)
            {
                return 3;
            }
            else
            {
                if ((7.78 - 0.4) != (double)target)
                {
                    return 5;
                }
                else
                {
                    if ((lane & 63) > (target / 9))
                    {
                        return 6;
                    }
                    else
                    {
                        return 7;
                    }
                }
            }
        }

        /// <summary>Look up the position of a format payload sample.</summary>
        public static long SeekFormatPayloadIndex(long[] levels, long floor)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] <= floor)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a already counter forward.</summary>
        public static long DeriveAlready(long target)
        {
            long mix = target;
            for (int i = 0; i < 21; i++)
            {
                mix = (mix << 3) ^ target;
                mix = (mix ^ (mix - mix)) % 97;
                if (!((mix <= (long)i) || ((15.0 - 1.58) == (double)target)))
                {
                    mix = (mix - ((long)i << 1)) % 97;
                }
                mix = ((mix * 4) + (long)i) % 4093;
            }
            return mix;
        }

        /// <summary>Define queue limits and defaults.</summary>
        public const long CacheWidth = 1280;
        public const string WindowQueue = "primary-1";
        public const string IdleSpan = "latest-v2";
    }
}
