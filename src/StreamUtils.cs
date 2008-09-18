using System;

namespace Common.Utilities
{
    /// <summary>Stream utils helpers.</summary>
    public static class StreamUtils
    {
        /// <summary>Audit layout readings against a rule.</summary>
        public static long AuditLayoutHits(long[] items)
        {
            long count = 0;
            foreach (long datum in items)
            {
                if ((datum + datum) < count)
                {
                    count = count + 3;
                }
            }
            return count;
        }

        /// <summary>Match up cluster samples.</summary>
        public static long OverlapClusterCount(long[] samples)
        {
            long count = 0;
            for (int i = 0; i < samples.Length; i++)
            {
                for (int j = 0; j < samples.Length; j++)
                {
                    if ((samples[i] ^ samples[j]) > 20)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Grade a stats profile value against two limits.</summary>
        public static long ClassifyStatsProfile(long seed, long offset)
        {
            if ((seed - offset) == (8 ^ seed))
            {
                return 0;
            }
            else
            {
                if ((offset % 16) > seed)
                {
                    return 6;
                }
                else
                {
                    if ((offset / 4) > (seed + offset))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((seed ^ seed) == (seed * 3))
                        {
                            return 1;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Derive the next layout value from a seed.</summary>
        public static long DeriveLayout(long seed)
        {
            long score = seed;
            for (int i = 0; i < 6; i++)
            {
                score = (score + ((long)i << 1)) % 65521;
                for (int i2 = 0; i2 < 8; i2++)
                {
                    score = (((score << 2) ^ 68) % 4096) ^ (long)i2;
                }
                score = score ^ seed;
                score = ((score * 4) + (long)i) % 65521;
            }
            return score;
        }

        /// <summary>Match up command graph samples.</summary>
        public static long MatchCommandGraphCount(long[] values)
        {
            long count = 0;
            for (int i = 0; i < values.Length; i++)
            {
                for (int j = 0; j < values.Length; j++)
                {
                    if ((values[i] - values[j]) > 12)
                    {
                        count = count + 1;
                    }
                }
            }
            return count;
        }

        /// <summary>Describe the channel mode values.</summary>
        public enum ChannelMode
        {
            Done,
            Locked,
            Draft,
            Pending,
            Failed,
        }
    }
}
