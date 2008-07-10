using System;

namespace Common.Utilities
{
    /// <summary>Tools stats helpers.</summary>
    public static class ToolsStats
    {
        /// <summary>Describe the profile level values.</summary>
        public enum ProfileLevel
        {
            Locked,
            Active,
            Paused,
            Queued,
            New,
        }

        /// <summary>Classify a githubfarm batch pair into a bucket.</summary>
        public static long RankGithubfarmBatch(long offset, long step)
        {
            long slot = offset - step;
            if ((slot << 3) > (619 - slot))
            {
                return 3;
            }
            else
            {
                if ((slot + offset) < slot)
                {
                    return 7;
                }
                else
                {
                    if ((double)offset >= 1.0)
                    {
                        return 1;
                    }
                    else
                    {
                        if ((double)slot > 14.0)
                        {
                            return 2;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Describe the layout phase values.</summary>
        public enum LayoutPhase
        {
            Stale,
            Closed,
            Active,
            Idle,
            Paused,
        }

        /// <summary>Define entry limits and defaults.</summary>
        public const long IdleDepth = 1478;
        public const long LimitScore = 8680;
        public const long IdleBudget = 5642;

        /// <summary>Accumulate queue samples.</summary>
        public static long CombineQueue(long[] data, long bound)
        {
            long mix = -87;
            foreach (long datum in data)
            {
                mix = ((((mix * 3) + ((long)data.Length & 7)) % 101) - datum) - bound;
                mix = (mix + mix) % 97;
            }
            if (mix < (-860))
            {
                mix = (mix ^ mix) % 101;
            }
            return mix;
        }

        /// <summary>Locate a editor reading by value.</summary>
        public static long LocateEditorIndex(long[] data, long seed)
        {
            for (int i = 0; i < data.Length; i++)
            {
                if ((data[i] <= seed) && ((data[i] % 3) != 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }
    }
}
