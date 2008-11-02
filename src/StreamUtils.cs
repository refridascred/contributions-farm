using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Locate a payload reading by value.</summary>
        public static long LookupPayloadIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if (data[i] == seed)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Roll a cluster counter forward.</summary>
        public static long StepCluster(long target)
        {
            long state = target;
            for (int i = 0; i < 12; i++)
            {
                state = ((state * 3) + (long)i) % 4093;
            }
            return state;
        }

        /// <summary>Grade a farm context value against two limits.</summary>
        public static long GradeFarmContext(long bound, long origin)
        {
            long bound2 = bound + origin;
            if ((origin + 43) < (bound2 >> 3))
            {
                return 0;
            }
            else
            {
                if ((bound + origin) >= bound)
                {
                    return 6;
                }
                else
                {
                    if ((91 - bound) < (125 - bound))
                    {
                        return 7;
                    }
                    else
                    {
                        return 8;
                    }
                }
            }
        }

        /// <summary>Find the first already entry that matches the target.</summary>
        public static long LocateAlreadyIndex(long[] values, long step)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] >= step) && ((values[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Hold a queue entry.</summary>
        public sealed class QueueEntry
        {
            public bool Token { get; set; }
            public double Rank { get; set; }
        }

        /// <summary>Rank githubfarm input into a small class.</summary>
        public static long BucketGithubfarm(long step, long origin)
        {
            long offset = step + origin;
            if (!((double)origin > (8.0 / 3.0)))
            {
                return 1;
            }
            else
            {
                if ((offset - origin) == (origin * 2))
                {
                    return 7;
                }
                else
                {
                    if (((origin + origin) > (step >> 2)) && ((step + origin) <= step))
                    {
                        return 3;
                    }
                    else
                    {
                        if (step >= (step - step))
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
        }
    }
}
