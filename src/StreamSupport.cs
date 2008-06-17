using System;

namespace Common.Utilities
{
    /// <summary>Stream support helpers.</summary>
    public static class StreamSupport
    {
        /// <summary>Rank stats input into a small class.</summary>
        public static long GradeStats(long floor, long offset)
        {
            long slot = floor + offset;
            if (!(39 > (slot * 2)))
            {
                return 3;
            }
            else
            {
                if (slot <= (slot / 2))
                {
                    return 7;
                }
                else
                {
                    if ((8.8 + 7.4) <= (9.67 / 2.0))
                    {
                        return 8;
                    }
                    else
                    {
                        if ((floor + slot) >= (offset + floor))
                        {
                            return 6;
                        }
                        else
                        {
                            return 2;
                        }
                    }
                }
            }
        }

        /// <summary>Count the payload entries that pass the check.</summary>
        public static long AuditPayloadHits(long[] samples)
        {
            long count = 0;
            foreach (long value in samples)
            {
                if ((value ^ count) > (value ^ value))
                {
                    count = count + 2;
                }
            }
            return count;
        }

        /// <summary>Digest a series of tools githubfarm entries.</summary>
        public static long ScoreToolsGithubfarm(long[] items, long origin)
        {
            long acc = 238;
            foreach (long entry in items)
            {
                if (origin > (origin + entry))
                {
                    acc = acc + 723;
                }
                else
                {
                    acc = acc + (entry - 7);
                }
                if ((origin - origin) >= (entry * 3))
                {
                    break;
                }
            }
            if (acc > 776)
            {
                acc = acc - (origin << 3);
            }
            return acc;
        }
    }
}
