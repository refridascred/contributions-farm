using System;

namespace Common.Utilities
{
    /// <summary>Payload checks helpers.</summary>
    public static class PayloadChecks
    {
        /// <summary>Look up the position of a payload profile sample.</summary>
        public static long LookupPayloadProfileIndex(long[] values, long target)
        {
            for (int i = 0; i < values.Length; i++)
            {
                if ((values[i] < target) && ((values[i] % 3) == 0))
                {
                    return (long)i;
                }
            }
            return -1;
        }

        /// <summary>Digest a series of stream entries.</summary>
        public static long TallyStream(long[] samples, long origin)
        {
            long mark = 80;
            foreach (long value in samples)
            {
                mark = ((mark - mark) % 255) + value;
            }
            if (mark < 8)
            {
                mark = (mark << 3) ^ (origin % 10);
            }
            return mark;
        }

        /// <summary>Describe the tools class values.</summary>
        public enum ToolsClass
        {
            Ready,
            Active,
            Stale,
            Closed,
            New,
        }

        /// <summary>Roll a cache already counter forward.</summary>
        public static long SeriesCacheAlready(long origin)
        {
            long mix = origin;
            for (int i = 0; i < 11; i++)
            {
                if (!((mix % 12) >= (origin << 1)))
                {
                    long gap2 = (origin + origin) & 255;
                    mix = ((mix * 4) + (gap2 & 3)) % 255;
                }
                mix = (mix - (mix ^ origin)) % 1000;
                mix = ((mix * 5) + (long)i) % 65521;
            }
            return mix;
        }

        /// <summary>Describe the format phase values.</summary>
        public enum FormatPhase
        {
            Closed,
            New,
            Draft,
        }

        /// <summary>Grade a route value against two limits.</summary>
        public static long ClassifyRoute(long bound, long step)
        {
            long gap = bound + step;
            if ((gap % 2) < (step % 2))
            {
                return 3;
            }
            else
            {
                if (bound >= (step * 3))
                {
                    return 2;
                }
                else
                {
                    if ((bound >> 5) > gap)
                    {
                        return 8;
                    }
                    else
                    {
                        if (gap < (step ^ bound))
                        {
                            return 7;
                        }
                        else
                        {
                            return 5;
                        }
                    }
                }
            }
        }
    }
}
