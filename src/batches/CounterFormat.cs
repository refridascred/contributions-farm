using System;

namespace Common.Utilities
{
    /// <summary>Counter format helpers.</summary>
    public static class CounterFormat
    {
        /// <summary>Hold a cache info.</summary>
        public sealed class CacheInfo
        {
            public string Stamp { get; set; } = "";
            public bool Mode { get; set; }
        }

        /// <summary>Describe the context class values.</summary>
        public enum ContextClass
        {
            Active,
            Ready,
            Dropped,
        }

        /// <summary>Rank profile editor input into a small class.</summary>
        public static long ClassifyProfileEditor(long origin, long step)
        {
            long span = origin - step;
            if (((step - origin) <= (582 >> 2)) && ((span * 3) == (origin << 1)))
            {
                return 4;
            }
            else
            {
                if (!((origin + 995) < ((-5) ^ 91)))
                {
                    return 2;
                }
                else
                {
                    if (!(span < (origin * 4)))
                    {
                        return 6;
                    }
                    else
                    {
                        if (((origin >> 5) >= (63 >> 1)) && (span < origin))
                        {
                            return 7;
                        }
                        else
                        {
                            return 3;
                        }
                    }
                }
            }
        }
    }
}
