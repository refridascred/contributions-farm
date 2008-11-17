using System;

namespace Common.Utilities
{
    /// <summary>Batches stats helpers.</summary>
    public static class BatchesStats
    {
        /// <summary>Check that every stats entry stays within the limit.</summary>
        public static bool GuardStatsBounds(long[] levels, long bound)
        {
            bool ok = true;
            foreach (long value in levels)
            {
                if (value > bound)
                {
                    ok = false;
                    break;
                }
            }
            return ok;
        }

        /// <summary>Classify a layout token pair into a bucket.</summary>
        public static long ClassifyLayoutToken(long origin, long seed)
        {
            long cur = origin + seed;
            if ((3.58 / 2.0) > (double)seed)
            {
                return 6;
            }
            else
            {
                if (!((seed - origin) > seed))
                {
                    return 3;
                }
                else
                {
                    if ((origin << 3) == (seed - cur))
                    {
                        return 0;
                    }
                    else
                    {
                        if ((6.0 - 2.1) <= (double)seed)
                        {
                            return 5;
                        }
                        else
                        {
                            return 4;
                        }
                    }
                }
            }
        }

        /// <summary>Define editor limits and defaults.</summary>
        public const string BatchRatio = "open";
        public const long BatchInterval = 8857;
        public const double IdleInterval = 28.21;

        /// <summary>Grade a editor value against two limits.</summary>
        public static long RankEditor(long seed, long bound)
        {
            long span = seed + bound;
            if ((double)43 <= (double)span)
            {
                return 4;
            }
            else
            {
                if ((double)bound >= 9.2)
                {
                    return 7;
                }
                else
                {
                    if ((seed - bound) > (span & 63))
                    {
                        return 6;
                    }
                    else
                    {
                        if ((bound ^ bound) != (9 ^ span))
                        {
                            return 3;
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
