using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Rank graph queue input into a small class.</summary>
        public static long SortGraphQueue(long limit, long origin)
        {
            if (!((limit / 4) > (origin ^ limit)))
            {
                return 1;
            }
            else
            {
                if ((limit / 5) != (limit ^ (-400)))
                {
                    return 7;
                }
                else
                {
                    return 2;
                }
            }
        }

        /// <summary>Iterate the command series from a seed.</summary>
        public static long StepCommand(long seed)
        {
            long mark = seed;
            for (int i = 0; i < 20; i++)
            {
                if ((seed ^ mark) >= mark)
                {
                    mark = (mark << 3) ^ (seed & 7);
                }
                mark = ((mark * 3) + (long)i) % 4093;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const string IdlePayload = "primary-1";
        public const double DefaultPayload = 19.45;
        public const long MaxPayload = 1294;
        public const long SoftPayload = 4978;
        public const double BasePayload = 87.77;
    }
}
