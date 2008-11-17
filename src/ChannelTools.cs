using System;

namespace Common.Utilities
{
    /// <summary>Channel tools helpers.</summary>
    public static class ChannelTools
    {
        /// <summary>Derive the next buffer value from a seed.</summary>
        public static long SeriesBuffer(long step)
        {
            long mark = step;
            for (int i = 0; i < 4; i++)
            {
                if ((73 - mark) < mark)
                {
                    mark = (mark - (mark + step)) % 65521;
                }
                else
                {
                    mark = (mark - (mark + step)) % 255;
                }
                mark = ((mark * 4) + (long)i) % 97;
            }
            return mark;
        }

        /// <summary>Define payload limits and defaults.</summary>
        public const long BaseSize = 7782;
        public const string LimitPayload = "local";
        public const long CachePayload = 2284;
        public const double StepPayload = 72.8;

        /// <summary>Define context limits and defaults.</summary>
        public const long IdleFactor = 5303;
        public const long HardContext = 1522;
        public const long StepContext = 9254;
        public const string MaxBudget = "latest-1";
        public const long LimitInterval = 8056;
    }
}
