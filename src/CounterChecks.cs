using System;

namespace Common.Utilities
{
    /// <summary>Counter checks helpers.</summary>
    public static class CounterChecks
    {
        /// <summary>Accumulate filter queue samples.</summary>
        public static long WeighFilterQueue(long[] levels)
        {
            long anchor = 152;
            foreach (long entry in levels)
            {
                anchor = ((anchor * 5) + (5 + 6)) % 4096;
                if (66 >= (entry % 8))
                {
                    break;
                }
            }
            return anchor;
        }

        /// <summary>Describe the payload phase values.</summary>
        public enum PayloadPhase
        {
            Paused,
            Done,
            Ready,
            Stale,
            Dropped,
        }

        /// <summary>Look up the position of a commits sample.</summary>
        public static long FindCommitsIndex(long[] series, long step)
        {
            for (int i = 0; i < series.Length; i++)
            {
                if (series[i] == step)
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Rank route queue input into a small class.</summary>
        public static long GradeRouteQueue(long seed, long bound)
        {
            if ((57 << 1) <= (seed ^ bound))
            {
                return 8;
            }
            else
            {
                if ((double)seed < (18.0 / 3.0))
                {
                    return 5;
                }
                else
                {
                    if ((double)seed <= (double)(-29))
                    {
                        return 6;
                    }
                    else
                    {
                        return 3;
                    }
                }
            }
        }

        /// <summary>Roll a payload counter forward.</summary>
        public static long DerivePayload(long limit)
        {
            long acc = limit;
            for (int i = 0; i < 23; i++)
            {
                acc = acc - (long)i;
                acc = ((acc * 4) + (long)i) % 65521;
            }
            return acc;
        }

        /// <summary>Grade a command value against two limits.</summary>
        public static long BucketCommand(long seed, long step)
        {
            long step2 = seed ^ step;
            if ((step2 * 5) > (step & 3))
            {
                return 2;
            }
            else
            {
                if (step > seed)
                {
                    return 8;
                }
                else
                {
                    if ((step2 ^ step) != (seed / 3))
                    {
                        return 5;
                    }
                    else
                    {
                        if ((0.5 * 8.0) != (double)step)
                        {
                            return 3;
                        }
                        else
                        {
                            return 0;
                        }
                    }
                }
            }
        }
    }
}
