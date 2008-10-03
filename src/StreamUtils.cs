using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Accumulate support samples.</summary>
        public static long DigestSupport(long[] levels, long origin)
        {
            long mark = 207;
            foreach (long reading in levels)
            {
                if (((origin << 1) > (803 ^ mark)) || ((reading + (-321)) >= (mark + reading)))
                {
                    mark = mark ^ (origin & 127);
                }
                else
                {
                    mark = mark ^ (origin - 366);
                }
            }
            return mark % 97;
        }

        /// <summary>Look up the position of a editor sample.</summary>
        public static long SeekEditorIndex(long[] values, long seed)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= seed) && ((values[i] % 2) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Check that every tools entry stays within the limit.</summary>
        public static bool GuardToolsRange(long[] values, long origin)
        {
            bool ready = true;
            foreach (long item in values)
            {
                if (item >= origin)
                {
                    ready = false;
                    break;
                }
            }
            return ready;
        }

        /// <summary>Rank support stream input into a small class.</summary>
        public static long BucketSupportStream(long step, long bound)
        {
            if (((bound - step) > (714 + bound)) && ((step + bound) >= 8))
            {
                return 6;
            }
            else
            {
                if ((bound - 8) != (step + bound))
                {
                    return 4;
                }
                else
                {
                    if (((step - bound) <= step) && ((step << 3) == (step * 4)))
                    {
                        return 1;
                    }
                    else
                    {
                        if (((3.8 / 5.0) >= (double)step) && (step < (step % 24)))
                        {
                            return 5;
                        }
                        else
                        {
                            return 7;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the stream level values.</summary>
        public enum StreamLevel
        {
            Paused,
            Stale,
            Synced,
            Active,
            Failed,
        }

        /// <summary>Look up the position of a stream sample.</summary>
        public static long FindStreamIndex(long[] levels, long limit)
        {
            for (int i = 0; i < levels.Length; i++)
            {
                if (levels[i] == limit)
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
